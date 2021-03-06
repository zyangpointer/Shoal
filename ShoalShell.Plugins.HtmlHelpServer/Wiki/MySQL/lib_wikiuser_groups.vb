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
''' DROP TABLE IF EXISTS `lib_wikiuser_groups`;
''' /*!40101 SET @saved_cs_client     = @@character_set_client */;
''' /*!40101 SET character_set_client = utf8 */;
''' CREATE TABLE `lib_wikiuser_groups` (
'''   `ug_user` int(10) unsigned NOT NULL DEFAULT '0',
'''   `ug_group` varbinary(255) NOT NULL DEFAULT '',
'''   UNIQUE KEY `ug_user_group` (`ug_user`,`ug_group`),
'''   KEY `ug_group` (`ug_group`)
''' ) ENGINE=InnoDB DEFAULT CHARSET=binary;
''' /*!40101 SET character_set_client = @saved_cs_client */;
''' 
''' --
''' 
''' </summary>
''' <remarks></remarks>
<Oracle.LinuxCompatibility.MySQL.Reflection.DbAttributes.TableName("lib_wikiuser_groups", Database:="wiki")>
Public Class lib_wikiuser_groups: Inherits Oracle.LinuxCompatibility.MySQL.SQLTable
#Region "Public Property Mapping To Database Fields"
    <DatabaseField("ug_user"), PrimaryKey, NotNull, DataType(MySqlDbType.Int64, "10")> Public Property ug_user As Long
    <DatabaseField("ug_group"), PrimaryKey, NotNull, DataType(MySqlDbType.Blob)> Public Property ug_group As Byte()
#End Region
#Region "Public SQL Interface"
#Region "Interface SQL"
    Private Shared ReadOnly INSERT_SQL As String = <SQL>INSERT INTO `lib_wikiuser_groups` (`ug_user`, `ug_group`) VALUES ('{0}', '{1}');</SQL>
    Private Shared ReadOnly REPLACE_SQL As String = <SQL>REPLACE INTO `lib_wikiuser_groups` (`ug_user`, `ug_group`) VALUES ('{0}', '{1}');</SQL>
    Private Shared ReadOnly DELETE_SQL As String = <SQL>DELETE FROM `lib_wikiuser_groups` WHERE `ug_user`='{0}' and `ug_group`='{1}';</SQL>
    Private Shared ReadOnly UPDATE_SQL As String = <SQL>UPDATE `lib_wikiuser_groups` SET `ug_user`='{0}', `ug_group`='{1}' WHERE `ug_user`='{2}' and `ug_group`='{3}';</SQL>
#End Region
    Public Overrides Function GetDeleteSQL() As String
        Return String.Format(DELETE_SQL, ug_user, ug_group)
    End Function
    Public Overrides Function GetInsertSQL() As String
        Return String.Format(INSERT_SQL, ug_user, ug_group)
    End Function
    Public Overrides Function GetReplaceSQL() As String
        Return String.Format(REPLACE_SQL, ug_user, ug_group)
    End Function
    Public Overrides Function GetUpdateSQL() As String
        Return String.Format(UPDATE_SQL, ug_user, ug_group, ug_user, ug_group)
    End Function
#End Region
End Class


End Namespace
