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
''' DROP TABLE IF EXISTS `lib_wikiquerycachetwo`;
''' /*!40101 SET @saved_cs_client     = @@character_set_client */;
''' /*!40101 SET character_set_client = utf8 */;
''' CREATE TABLE `lib_wikiquerycachetwo` (
'''   `qcc_type` varbinary(32) NOT NULL,
'''   `qcc_value` int(10) unsigned NOT NULL DEFAULT '0',
'''   `qcc_namespace` int(11) NOT NULL DEFAULT '0',
'''   `qcc_title` varbinary(255) NOT NULL DEFAULT '',
'''   `qcc_namespacetwo` int(11) NOT NULL DEFAULT '0',
'''   `qcc_titletwo` varbinary(255) NOT NULL DEFAULT '',
'''   KEY `qcc_type` (`qcc_type`,`qcc_value`),
'''   KEY `qcc_title` (`qcc_type`,`qcc_namespace`,`qcc_title`),
'''   KEY `qcc_titletwo` (`qcc_type`,`qcc_namespacetwo`,`qcc_titletwo`)
''' ) ENGINE=InnoDB DEFAULT CHARSET=binary;
''' /*!40101 SET character_set_client = @saved_cs_client */;
''' 
''' --
''' 
''' </summary>
''' <remarks></remarks>
<Oracle.LinuxCompatibility.MySQL.Reflection.DbAttributes.TableName("lib_wikiquerycachetwo", Database:="wiki")>
Public Class lib_wikiquerycachetwo: Inherits Oracle.LinuxCompatibility.MySQL.SQLTable
#Region "Public Property Mapping To Database Fields"
    <DatabaseField("qcc_type"), PrimaryKey, NotNull, DataType(MySqlDbType.Blob)> Public Property qcc_type As Byte()
    <DatabaseField("qcc_value"), PrimaryKey, NotNull, DataType(MySqlDbType.Int64, "10")> Public Property qcc_value As Long
    <DatabaseField("qcc_namespace"), NotNull, DataType(MySqlDbType.Int64, "11")> Public Property qcc_namespace As Long
    <DatabaseField("qcc_title"), NotNull, DataType(MySqlDbType.Blob)> Public Property qcc_title As Byte()
    <DatabaseField("qcc_namespacetwo"), NotNull, DataType(MySqlDbType.Int64, "11")> Public Property qcc_namespacetwo As Long
    <DatabaseField("qcc_titletwo"), NotNull, DataType(MySqlDbType.Blob)> Public Property qcc_titletwo As Byte()
#End Region
#Region "Public SQL Interface"
#Region "Interface SQL"
    Private Shared ReadOnly INSERT_SQL As String = <SQL>INSERT INTO `lib_wikiquerycachetwo` (`qcc_type`, `qcc_value`, `qcc_namespace`, `qcc_title`, `qcc_namespacetwo`, `qcc_titletwo`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}');</SQL>
    Private Shared ReadOnly REPLACE_SQL As String = <SQL>REPLACE INTO `lib_wikiquerycachetwo` (`qcc_type`, `qcc_value`, `qcc_namespace`, `qcc_title`, `qcc_namespacetwo`, `qcc_titletwo`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}');</SQL>
    Private Shared ReadOnly DELETE_SQL As String = <SQL>DELETE FROM `lib_wikiquerycachetwo` WHERE `qcc_type`='{0}' and `qcc_value`='{1}';</SQL>
    Private Shared ReadOnly UPDATE_SQL As String = <SQL>UPDATE `lib_wikiquerycachetwo` SET `qcc_type`='{0}', `qcc_value`='{1}', `qcc_namespace`='{2}', `qcc_title`='{3}', `qcc_namespacetwo`='{4}', `qcc_titletwo`='{5}' WHERE `qcc_type`='{6}' and `qcc_value`='{7}';</SQL>
#End Region
    Public Overrides Function GetDeleteSQL() As String
        Return String.Format(DELETE_SQL, qcc_type, qcc_value)
    End Function
    Public Overrides Function GetInsertSQL() As String
        Return String.Format(INSERT_SQL, qcc_type, qcc_value, qcc_namespace, qcc_title, qcc_namespacetwo, qcc_titletwo)
    End Function
    Public Overrides Function GetReplaceSQL() As String
        Return String.Format(REPLACE_SQL, qcc_type, qcc_value, qcc_namespace, qcc_title, qcc_namespacetwo, qcc_titletwo)
    End Function
    Public Overrides Function GetUpdateSQL() As String
        Return String.Format(UPDATE_SQL, qcc_type, qcc_value, qcc_namespace, qcc_title, qcc_namespacetwo, qcc_titletwo, qcc_type, qcc_value)
    End Function
#End Region
End Class


End Namespace
