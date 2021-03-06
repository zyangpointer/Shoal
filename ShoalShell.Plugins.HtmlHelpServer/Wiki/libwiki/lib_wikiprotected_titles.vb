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
''' DROP TABLE IF EXISTS `lib_wikiprotected_titles`;
''' /*!40101 SET @saved_cs_client     = @@character_set_client */;
''' /*!40101 SET character_set_client = utf8 */;
''' CREATE TABLE `lib_wikiprotected_titles` (
'''   `pt_namespace` int(11) NOT NULL,
'''   `pt_title` varbinary(255) NOT NULL,
'''   `pt_user` int(10) unsigned NOT NULL,
'''   `pt_reason` varbinary(767) DEFAULT NULL,
'''   `pt_timestamp` binary(14) NOT NULL,
'''   `pt_expiry` varbinary(14) NOT NULL DEFAULT '',
'''   `pt_create_perm` varbinary(60) NOT NULL,
'''   UNIQUE KEY `pt_namespace_title` (`pt_namespace`,`pt_title`),
'''   KEY `pt_timestamp` (`pt_timestamp`)
''' ) ENGINE=InnoDB DEFAULT CHARSET=binary;
''' /*!40101 SET character_set_client = @saved_cs_client */;
''' 
''' --
''' 
''' </summary>
''' <remarks></remarks>
<Oracle.LinuxCompatibility.MySQL.Reflection.DbAttributes.TableName("lib_wikiprotected_titles", Database:="wiki")>
Public Class lib_wikiprotected_titles: Inherits Oracle.LinuxCompatibility.MySQL.SQLTable
#Region "Public Property Mapping To Database Fields"
    <DatabaseField("pt_namespace"), PrimaryKey, NotNull, DataType(MySqlDbType.Int64, "11")> Public Property pt_namespace As Long
    <DatabaseField("pt_title"), PrimaryKey, NotNull, DataType(MySqlDbType.Blob)> Public Property pt_title As Byte()
    <DatabaseField("pt_user"), NotNull, DataType(MySqlDbType.Int64, "10")> Public Property pt_user As Long
    <DatabaseField("pt_reason"), DataType(MySqlDbType.Blob)> Public Property pt_reason As Byte()
    <DatabaseField("pt_timestamp"), NotNull, DataType(MySqlDbType.Blob)> Public Property pt_timestamp As Byte()
    <DatabaseField("pt_expiry"), NotNull, DataType(MySqlDbType.Blob)> Public Property pt_expiry As Byte()
    <DatabaseField("pt_create_perm"), NotNull, DataType(MySqlDbType.Blob)> Public Property pt_create_perm As Byte()
#End Region
#Region "Public SQL Interface"
#Region "Interface SQL"
    Private Shared ReadOnly INSERT_SQL As String = <SQL>INSERT INTO `lib_wikiprotected_titles` (`pt_namespace`, `pt_title`, `pt_user`, `pt_reason`, `pt_timestamp`, `pt_expiry`, `pt_create_perm`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}');</SQL>
    Private Shared ReadOnly REPLACE_SQL As String = <SQL>REPLACE INTO `lib_wikiprotected_titles` (`pt_namespace`, `pt_title`, `pt_user`, `pt_reason`, `pt_timestamp`, `pt_expiry`, `pt_create_perm`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}');</SQL>
    Private Shared ReadOnly DELETE_SQL As String = <SQL>DELETE FROM `lib_wikiprotected_titles` WHERE `pt_namespace`='{0}' and `pt_title`='{1}';</SQL>
    Private Shared ReadOnly UPDATE_SQL As String = <SQL>UPDATE `lib_wikiprotected_titles` SET `pt_namespace`='{0}', `pt_title`='{1}', `pt_user`='{2}', `pt_reason`='{3}', `pt_timestamp`='{4}', `pt_expiry`='{5}', `pt_create_perm`='{6}' WHERE `pt_namespace`='{7}' and `pt_title`='{8}';</SQL>
#End Region
    Public Overrides Function GetDeleteSQL() As String
        Return String.Format(DELETE_SQL, pt_namespace, pt_title)
    End Function
    Public Overrides Function GetInsertSQL() As String
        Return String.Format(INSERT_SQL, pt_namespace, pt_title, pt_user, pt_reason, pt_timestamp, pt_expiry, pt_create_perm)
    End Function
    Public Overrides Function GetReplaceSQL() As String
        Return String.Format(REPLACE_SQL, pt_namespace, pt_title, pt_user, pt_reason, pt_timestamp, pt_expiry, pt_create_perm)
    End Function
    Public Overrides Function GetUpdateSQL() As String
        Return String.Format(UPDATE_SQL, pt_namespace, pt_title, pt_user, pt_reason, pt_timestamp, pt_expiry, pt_create_perm, pt_namespace, pt_title)
    End Function
#End Region
End Class


End Namespace
