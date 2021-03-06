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
''' DROP TABLE IF EXISTS `lib_wikimodule_deps`;
''' /*!40101 SET @saved_cs_client     = @@character_set_client */;
''' /*!40101 SET character_set_client = utf8 */;
''' CREATE TABLE `lib_wikimodule_deps` (
'''   `md_module` varbinary(255) NOT NULL,
'''   `md_skin` varbinary(32) NOT NULL,
'''   `md_deps` mediumblob NOT NULL,
'''   UNIQUE KEY `md_module_skin` (`md_module`,`md_skin`)
''' ) ENGINE=InnoDB DEFAULT CHARSET=binary;
''' /*!40101 SET character_set_client = @saved_cs_client */;
''' 
''' --
''' 
''' </summary>
''' <remarks></remarks>
<Oracle.LinuxCompatibility.MySQL.Reflection.DbAttributes.TableName("lib_wikimodule_deps", Database:="wiki")>
Public Class lib_wikimodule_deps: Inherits Oracle.LinuxCompatibility.MySQL.SQLTable
#Region "Public Property Mapping To Database Fields"
    <DatabaseField("md_module"), PrimaryKey, NotNull, DataType(MySqlDbType.Blob)> Public Property md_module As Byte()
    <DatabaseField("md_skin"), PrimaryKey, NotNull, DataType(MySqlDbType.Blob)> Public Property md_skin As Byte()
    <DatabaseField("md_deps"), NotNull, DataType(MySqlDbType.Blob)> Public Property md_deps As Byte()
#End Region
#Region "Public SQL Interface"
#Region "Interface SQL"
    Private Shared ReadOnly INSERT_SQL As String = <SQL>INSERT INTO `lib_wikimodule_deps` (`md_module`, `md_skin`, `md_deps`) VALUES ('{0}', '{1}', '{2}');</SQL>
    Private Shared ReadOnly REPLACE_SQL As String = <SQL>REPLACE INTO `lib_wikimodule_deps` (`md_module`, `md_skin`, `md_deps`) VALUES ('{0}', '{1}', '{2}');</SQL>
    Private Shared ReadOnly DELETE_SQL As String = <SQL>DELETE FROM `lib_wikimodule_deps` WHERE `md_module`='{0}' and `md_skin`='{1}';</SQL>
    Private Shared ReadOnly UPDATE_SQL As String = <SQL>UPDATE `lib_wikimodule_deps` SET `md_module`='{0}', `md_skin`='{1}', `md_deps`='{2}' WHERE `md_module`='{3}' and `md_skin`='{4}';</SQL>
#End Region
    Public Overrides Function GetDeleteSQL() As String
        Return String.Format(DELETE_SQL, md_module, md_skin)
    End Function
    Public Overrides Function GetInsertSQL() As String
        Return String.Format(INSERT_SQL, md_module, md_skin, md_deps)
    End Function
    Public Overrides Function GetReplaceSQL() As String
        Return String.Format(REPLACE_SQL, md_module, md_skin, md_deps)
    End Function
    Public Overrides Function GetUpdateSQL() As String
        Return String.Format(UPDATE_SQL, md_module, md_skin, md_deps, md_module, md_skin)
    End Function
#End Region
End Class


End Namespace
