REM  Oracle.LinuxCompatibility.MySQL.CodeGenerator
REM  MYSQL Schema Mapper
REM      for Microsoft VisualBasic.NET 

REM  Dump @12/3/2015 8:20:41 PM


Imports Oracle.LinuxCompatibility.MySQL.Reflection.DbAttributes

Namespace Wiki.MySQL

''' <summary>
''' 
''' --
''' 
''' DROP TABLE IF EXISTS `lib_wikilanglinks`;
''' /*!40101 SET @saved_cs_client     = @@character_set_client */;
''' /*!40101 SET character_set_client = utf8 */;
''' CREATE TABLE `lib_wikilanglinks` (
'''   `ll_from` int(10) unsigned NOT NULL DEFAULT '0',
'''   `ll_lang` varbinary(20) NOT NULL DEFAULT '',
'''   `ll_title` varbinary(255) NOT NULL DEFAULT '',
'''   UNIQUE KEY `ll_from` (`ll_from`,`ll_lang`),
'''   KEY `ll_lang` (`ll_lang`,`ll_title`)
''' ) ENGINE=InnoDB DEFAULT CHARSET=binary;
''' /*!40101 SET character_set_client = @saved_cs_client */;
''' 
''' --
''' 
''' </summary>
''' <remarks></remarks>
<Oracle.LinuxCompatibility.MySQL.Reflection.DbAttributes.TableName("lib_wikilanglinks", Database:="wiki")>
Public Class lib_wikilanglinks: Inherits Oracle.LinuxCompatibility.MySQL.SQLTable
#Region "Public Property Mapping To Database Fields"
    <DatabaseField("ll_from"), PrimaryKey, NotNull, DataType(MySqlDbType.Int64, "10")> Public Property ll_from As Long
    <DatabaseField("ll_lang"), PrimaryKey, NotNull, DataType(MySqlDbType.Blob)> Public Property ll_lang As Byte()
    <DatabaseField("ll_title"), NotNull, DataType(MySqlDbType.Blob)> Public Property ll_title As Byte()
#End Region
#Region "Public SQL Interface"
#Region "Interface SQL"
    Private Shared ReadOnly INSERT_SQL As String = <SQL>INSERT INTO `lib_wikilanglinks` (`ll_from`, `ll_lang`, `ll_title`) VALUES ('{0}', '{1}', '{2}');</SQL>
    Private Shared ReadOnly REPLACE_SQL As String = <SQL>REPLACE INTO `lib_wikilanglinks` (`ll_from`, `ll_lang`, `ll_title`) VALUES ('{0}', '{1}', '{2}');</SQL>
    Private Shared ReadOnly DELETE_SQL As String = <SQL>DELETE FROM `lib_wikilanglinks` WHERE `ll_from`='{0}' and `ll_lang`='{1}';</SQL>
    Private Shared ReadOnly UPDATE_SQL As String = <SQL>UPDATE `lib_wikilanglinks` SET `ll_from`='{0}', `ll_lang`='{1}', `ll_title`='{2}' WHERE `ll_from`='{3}' and `ll_lang`='{4}';</SQL>
#End Region
    Public Overrides Function GetDeleteSQL() As String
        Return String.Format(DELETE_SQL, ll_from, ll_lang)
    End Function
    Public Overrides Function GetInsertSQL() As String
        Return String.Format(INSERT_SQL, ll_from, ll_lang, ll_title)
    End Function
    Public Overrides Function GetReplaceSQL() As String
        Return String.Format(REPLACE_SQL, ll_from, ll_lang, ll_title)
    End Function
    Public Overrides Function GetUpdateSQL() As String
        Return String.Format(UPDATE_SQL, ll_from, ll_lang, ll_title, ll_from, ll_lang)
    End Function
#End Region
End Class


End Namespace
