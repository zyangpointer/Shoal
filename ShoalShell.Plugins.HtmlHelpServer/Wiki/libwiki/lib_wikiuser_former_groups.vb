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
''' DROP TABLE IF EXISTS `lib_wikiuser_former_groups`;
''' /*!40101 SET @saved_cs_client     = @@character_set_client */;
''' /*!40101 SET character_set_client = utf8 */;
''' CREATE TABLE `lib_wikiuser_former_groups` (
'''   `ufg_user` int(10) unsigned NOT NULL DEFAULT '0',
'''   `ufg_group` varbinary(255) NOT NULL DEFAULT '',
'''   UNIQUE KEY `ufg_user_group` (`ufg_user`,`ufg_group`)
''' ) ENGINE=InnoDB DEFAULT CHARSET=binary;
''' /*!40101 SET character_set_client = @saved_cs_client */;
''' 
''' --
''' 
''' </summary>
''' <remarks></remarks>
<Oracle.LinuxCompatibility.MySQL.Reflection.DbAttributes.TableName("lib_wikiuser_former_groups", Database:="wiki")>
Public Class lib_wikiuser_former_groups: Inherits Oracle.LinuxCompatibility.MySQL.SQLTable
#Region "Public Property Mapping To Database Fields"
    <DatabaseField("ufg_user"), PrimaryKey, NotNull, DataType(MySqlDbType.Int64, "10")> Public Property ufg_user As Long
    <DatabaseField("ufg_group"), PrimaryKey, NotNull, DataType(MySqlDbType.Blob)> Public Property ufg_group As Byte()
#End Region
#Region "Public SQL Interface"
#Region "Interface SQL"
    Private Shared ReadOnly INSERT_SQL As String = <SQL>INSERT INTO `lib_wikiuser_former_groups` (`ufg_user`, `ufg_group`) VALUES ('{0}', '{1}');</SQL>
    Private Shared ReadOnly REPLACE_SQL As String = <SQL>REPLACE INTO `lib_wikiuser_former_groups` (`ufg_user`, `ufg_group`) VALUES ('{0}', '{1}');</SQL>
    Private Shared ReadOnly DELETE_SQL As String = <SQL>DELETE FROM `lib_wikiuser_former_groups` WHERE `ufg_user`='{0}' and `ufg_group`='{1}';</SQL>
    Private Shared ReadOnly UPDATE_SQL As String = <SQL>UPDATE `lib_wikiuser_former_groups` SET `ufg_user`='{0}', `ufg_group`='{1}' WHERE `ufg_user`='{2}' and `ufg_group`='{3}';</SQL>
#End Region
    Public Overrides Function GetDeleteSQL() As String
        Return String.Format(DELETE_SQL, ufg_user, ufg_group)
    End Function
    Public Overrides Function GetInsertSQL() As String
        Return String.Format(INSERT_SQL, ufg_user, ufg_group)
    End Function
    Public Overrides Function GetReplaceSQL() As String
        Return String.Format(REPLACE_SQL, ufg_user, ufg_group)
    End Function
    Public Overrides Function GetUpdateSQL() As String
        Return String.Format(UPDATE_SQL, ufg_user, ufg_group, ufg_user, ufg_group)
    End Function
#End Region
End Class


End Namespace
