﻿Namespace Interpreter.Linker.APIHandler.Alignment

    ''' <summary>
    ''' 所输入的参数是可能没有顺序的，但是函数的参数定义是有顺序的
    ''' </summary>
    Public Module FunctionCalls

        Public ReadOnly Property ExtensionMethodCaller As String =
            NameOf(Parser.Tokens.ParameterName.ParameterType.ExtensionMethodCaller)
        Public ReadOnly Property OrderReference As String = NameOf(Parser.Tokens.ParameterName.ParameterType.OrderReference)

        ''' <summary>
        ''' 用户所输入的参数是否是和函数的定义的顺序是一致的
        ''' </summary>
        ''' <typeparam name="T"></typeparam>
        ''' <param name="InputParam"></param>
        ''' <returns></returns>
        Public Function IsOrderReference(Of T)(InputParam As KeyValuePair(Of String, T)()) As Boolean
            If InputParam.IsNullOrEmpty OrElse InputParam.Length = 1 Then
                Return False
            End If

            Return String.Equals(OrderReference, InputParam(1).Key)
        End Function

        Private Function __alignType(paramDef As Type, valueInput As Object, ByRef score As Integer, ByRef outRef As Object) As Boolean
            Dim equalsValue As Integer
            Dim inputType As Type = valueInput.GetType

            If TypeEquals.TypeEquals(paramDef, inputType).ShadowCopy(equalsValue) > 0 Then
                score += equalsValue
                outRef = valueInput
            Else
                If Microsoft.VisualBasic.Scripting.InputHandler.CanbeHandle(inputType, paramDef) Then
                    score += 20
                    outRef = CTypeDynamic(valueInput, paramDef)
                Else
                    Return False
                End If
            End If

            Return True
        End Function

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="paramDef">函数之中的参数类型的定义</param>
        ''' <param name="valueInput"></param>
        ''' <returns></returns>
        Public Function AlignType(paramDef As Type, valueInput As Object) As Object
            Dim out As Object = Nothing
            Call __alignType(paramDef, valueInput, 0, out)
            Return out
        End Function

        ''' <summary>
        ''' 一一对应比较
        ''' </summary>
        ''' <param name="FuncDef"></param>
        ''' <param name="InputParam"></param>
        ''' <returns></returns>
        ''' <remarks>一一对应比较和参数名无关</remarks>
        Public Function OrderReferenceAlignment(FuncDef As System.Reflection.ParameterInfo(), InputParam As Object()) As ParamAlignments
            Dim score As Integer
            Dim args As New List(Of Object)

            For i As Integer = 0 To FuncDef.Length - 1
                Dim paramDef = FuncDef(i)

                If i <= InputParam.Length - 1 Then

                    Dim valueInput As Object = InputParam(i)

                    If __boolsEquals(paramDef, valueInput) Then

                        score += 100
                        Call args.Add(True)

                    Else

                        If Not __alignType(paramDef.ParameterType, valueInput, score, valueInput) Then
                            Return Nothing
                        Else
                            Call args.Add(valueInput)
                        End If
                    End If

                Else '判断函数参数是否为可选类型的

                    If paramDef.IsOptional Then
                        score += 100
                        Call args.Add(paramDef.DefaultValue)
                    Else
                        Return Nothing
                    End If
                End If
            Next

            Return New ParamAlignments With {.Score = score, .args = args.ToArray}
        End Function

        ''' <summary>
        ''' 处理逻辑开关标记的
        ''' </summary>
        ''' <param name="FuncDef"></param>
        ''' <param name="inputParam"></param>
        ''' <returns>函数不会计算拓展函数的调用参数</returns>
        Private Function __boolsEquals(FuncDef As System.Reflection.ParameterInfo, inputParam As Object) As Boolean
            If Not FuncDef.Equals(Bool) Then Return False
            If Not inputParam.GetType.Equals(GetType(String)) Then Return False

            Dim str As String = DirectCast(inputParam, String)

            If CommandLine.IsPossibleLogicSW(str) Then
                str = CommandLine.TrimBooleanSwitchPrefix(str)

                Return String.Equals(FuncDef.Name,  '开关还要和参数名相同
                                     str,
                                     StringComparison.OrdinalIgnoreCase)
            Else
                Return False
            End If
        End Function

        ReadOnly Bool As Type = GetType(Boolean)

        Public Class ParamAlignments

            Public Property Score As Integer
            Public Property args As Object()

        End Class

        ''' <summary>
        ''' 使用这个函数来进行判断
        ''' </summary>
        ''' <param name="FuncDef"></param>
        ''' <param name="InputParam"></param>
        ''' <returns></returns>
        Public Function OverloadsAlignment(FuncDef As System.Reflection.MethodInfo, InputParam As KeyValuePair(Of String, Object)()) As ParamAlignments
            Dim inputParamType = (From obj In InputParam Select New KeyValuePair(Of String, Type)(obj.Key, obj.Value.GetType)).ToArray

            If IsOrderReference(inputParamType) Then
                Return OrderReferenceAlignment(FuncDef.GetParameters, (From obj In InputParam Select obj.Value).ToArray) '需要顺序比较，所以不用并行来破环原有的顺序
            Else
                Return OverloadsAlignment(FuncDef, InputParam.ToDictionary(Function(obj) obj.Key, elementSelector:=Function(obj) obj.Value))
            End If
        End Function

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="FuncDef"></param>
        ''' <param name="InputParam"></param>
        ''' <returns></returns>
        Private Function OverloadsAlignment(FuncDef As System.Reflection.MethodInfo, InputParam As Dictionary(Of String, Object)) As ParamAlignments
            Dim FuncParameters = FuncDef.GetParameters

            If FuncParameters.IsNullOrEmpty Then
                Dim score As Integer

                If InputParam.IsNullOrEmpty Then
                    score = Integer.MaxValue
                Else
                    score = 1 '函数没有任何参数，也可以调用
                End If

                Return New ParamAlignments With {.Score = score, .args = New Object() {}}
            End If

            If FuncParameters.Length = 1 Then '函数只有一个参数
                Return New OneParameter(FuncParameters(Scan0), InputParam).OverloadsAlignment
            End If

            If FuncParameters.Length = 2 Then
                Return New TwoParameter(FuncParameters, InputParam).OverloadsAlignment
            End If

            Return MultipleAlignment(FuncParameters, InputParam)
        End Function

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="FuncDef"></param>
        ''' <param name="InputParam"></param>
        ''' <returns></returns>
        Private Function MultipleAlignment(FuncDef As System.Reflection.ParameterInfo(), ByRef InputParam As Dictionary(Of String, Object)) As ParamAlignments
            Dim score As Integer
            Dim offset As Integer = 0
            Dim args As New List(Of Object)

            If InputParam.ContainsKey(ExtensionMethodCaller) Then
                Dim valueInput As Object = InputParam(ExtensionMethodCaller)
                Dim paramType As Type = FuncDef(Scan0).ParameterType

                If Not __alignType(paramType, valueInput, score, valueInput) Then
                    Return Nothing
                Else
                    Call args.Add(valueInput)
                End If

                Call InputParam.Remove(ExtensionMethodCaller)
            End If

            FuncDef = FuncDef.Skip(offset).ToArray
            Dim tmpAlign = OrderAlignment(FuncDef, InputParam) '已经没有其他的特殊的类型了直接顺序比较

            If tmpAlign Is Nothing Then
                Return Nothing
            End If

            score += tmpAlign.Score
            args.AddRange(tmpAlign.args)

            Return New ParamAlignments With {.Score = score, .args = args.ToArray}
        End Function

        Private Class TwoParameter : Inherits SpecialAlignment(Of System.Reflection.ParameterInfo())

            Sub New(FuncDef As System.Reflection.ParameterInfo(), ByRef InputParam As Dictionary(Of String, Object))
                Call MyBase.New(FuncDef, InputParam)
            End Sub

            Public Overrides Function OverloadsAlignment() As ParamAlignments
                Dim score As Integer
                Dim valueInput As Object
                Dim args As New List(Of Object)

                If InputParam.ContainsKey(ExtensionMethodCaller) Then
                    valueInput = InputParam(ExtensionMethodCaller)
                    Dim paramType As Type = FuncDef(Scan0).ParameterType

                    If Not __alignType(paramType, valueInput, score, valueInput) Then
                        Return Nothing
                    Else
                        Call args.Add(valueInput)
                    End If

                    If InputParam.ContainsKey(ExtSingle) Then

                        Dim paramDef = FuncDef(1)
                        valueInput = InputParam(ExtSingle)

                        If __boolsEquals(paramDef, valueInput) Then
                            score += 100
                            Call args.Add(True)
                        Else

                            If Not __alignType(paramDef.ParameterType, valueInput, score, valueInput) Then
                                Return Nothing
                            Else
                                Call args.Add(valueInput)
                            End If
                        End If

                        Return New ParamAlignments With {.Score = score, .args = args.ToArray}
                    Else

                        Call InputParam.Remove(ExtensionMethodCaller)

                        Dim tmpAlign = New OneParameter(FuncDef(1), InputParam).OverloadsAlignment

                        If tmpAlign Is Nothing Then
                            Return Nothing
                        End If

                        score += tmpAlign.Score
                        Return New ParamAlignments With {.Score = score, .args = args.Join(tmpAlign.args).ToArray}

                    End If

                Else  '普通的, 直接按照顺序进行比较

                    Return OrderAlignment(FuncDef, InputParam)

                End If
            End Function
        End Class

        ''' <summary>
        ''' 输入的参数里面是没有任何的特殊的名称的，会使用字典查询，不会像<see cref="functioncalls.OrderReferenceAlignment(System.Reflection.ParameterInfo(), Object())"/>
        ''' </summary>
        ''' <param name="FuncDef"></param>
        ''' <param name="InputParam"></param>
        ''' <returns></returns>
        Private Function OrderAlignment(FuncDef As System.Reflection.ParameterInfo(), ByRef InputParam As Dictionary(Of String, Object)) As ParamAlignments
            Dim score As Integer = 0
            Dim args As New List(Of Object)

            If InputParam.Count = 1 AndAlso (String.Equals(InputParam.First.Key, SingleParameter) OrElse String.Equals(InputParam.First.Key, ExtSingle)) Then

                Dim value As Object = InputParam.First.Value
                Dim paramType As Type = FuncDef(Scan0).ParameterType

                If __alignType(paramType, value, score, value) Then
                    Call args.Add(value)
                Else
                    Return Nothing
                End If

                If Not FuncDef(1).IsOptional Then
                    Return Nothing

                Else

                    For Each param In FuncDef.Skip(1)
                        score += 10
                        Call args.Add(param.DefaultValue)
                    Next

                    Return New ParamAlignments With {.Score = score, .args = args.ToArray}

                End If

            End If

            For Each param In FuncDef
                Dim Name As String = Scripting.MetaData.Parameter.GetAliasNameView(param).ToLower

                If Not InputParam.ContainsKey(Name) Then
                    '在输入的参数里面找不到，可能是函数的这个参数为可选的
                    If param.IsOptional Then
                        score += 10
                        Call args.Add(param.DefaultValue)
                        Continue For
                    Else
                        Return Nothing
                    End If
                End If

                Dim valueInput As Object = InputParam(Name)
                Dim InputType As Type = valueInput.GetType

                If __boolsEquals(param, valueInput) Then

                    score += 100
                    Call args.Add(True)

                Else

                    If Not __alignType(param.ParameterType, valueInput, score, valueInput) Then
                        Return Nothing
                    Else
                        Call args.Add(valueInput)
                    End If

                End If
            Next

            Return New ParamAlignments With {.Score = score, .args = args.ToArray}
        End Function

        Public ReadOnly Property ExtSingle As String = NameOf(Parser.Tokens.ParameterName.ParameterType.EXtensionSingleParameter)
        Public ReadOnly Property SingleParameter As String = NameOf(Parser.Tokens.ParameterName.ParameterType.SingleParameter)

        Private MustInherit Class SpecialAlignment(Of T)
            Protected InputParam As Dictionary(Of String, Object)
            Protected FuncDef As T

            Sub New(FuncDef As T, ByRef InputParam As Dictionary(Of String, Object))
                Me.FuncDef = FuncDef
                Me.InputParam = InputParam
            End Sub

            Public MustOverride Function OverloadsAlignment() As ParamAlignments
        End Class

        Private Class OneParameter : Inherits SpecialAlignment(Of System.Reflection.ParameterInfo)

            Sub New(FuncDef As System.Reflection.ParameterInfo, ByRef InputParam As Dictionary(Of String, Object))
                Call MyBase.New(FuncDef, InputParam)
            End Sub

            Public Overrides Function OverloadsAlignment() As ParamAlignments
                If InputParam.IsNullOrEmpty Then '输入的参数是空的，则判断函数参数是否为可选参数

                    If Not FuncDef.IsOptional Then
                        Return Nothing
                    Else
                        Return New ParamAlignments With {.Score = 10, .args = {FuncDef.DefaultValue}}
                    End If

                End If

                Dim pName As String =
                    Microsoft.VisualBasic.Scripting.MetaData.Parameter.GetAliasNameView(FuncDef).ToLower

                If InputParam.ContainsKey(pName) Then
                    Return __equals(pName)
                End If

                If InputParam.ContainsKey(FunctionCalls.ExtensionMethodCaller) Then       '拓展方法参数
                    Return __equals(FunctionCalls.ExtensionMethodCaller)
                End If

                If InputParam.ContainsKey(FunctionCalls.SingleParameter) Then
                    Return __equals(FunctionCalls.SingleParameter)
                End If

                Return Nothing  '都找不到相同的定义，则肯定不可以进行调用
            End Function

            Private Function __equals(Name As String) As ParamAlignments
                Dim equalsValue As Integer
                Dim valueInput As Object = InputParam(Name)

                If __boolsEquals(FuncDef, valueInput) Then
                    Return New ParamAlignments With {.Score = 100, .args = {True}}
                Else

                    Dim inputType As Type = valueInput.GetType

                    If TypeEquals.TypeEquals(FuncDef.ParameterType, inputType).ShadowCopy(equalsValue) > 0 Then
                        Return New ParamAlignments With {.Score = equalsValue, .args = {valueInput}}
                    Else

                        If Microsoft.VisualBasic.Scripting.InputHandler.CanbeHandle(inputType, FuncDef.ParameterType) Then
                            Return New ParamAlignments With {.Score = 20, .args = {CTypeDynamic(valueInput, FuncDef.ParameterType)}}
                        Else
                            Return Nothing
                        End If
                    End If
                End If
            End Function
        End Class
    End Module
End Namespace