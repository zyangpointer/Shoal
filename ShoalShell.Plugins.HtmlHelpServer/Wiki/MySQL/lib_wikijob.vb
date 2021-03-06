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
''' DROP TABLE IF EXISTS `lib_wikijob`;
''' /*!40101 SET @saved_cs_client     = @@character_set_client */;
''' /*!40101 SET character_set_client = utf8 */;
''' CREATE TABLE `lib_wikijob` (
'''   `job_id` int(10) unsigned NOT NULL AUTO_INCREMENT,
'''   `job_cmd` varbinary(60) NOT NULL DEFAULT '',
'''   `job_namespace` int(11) NOT NULL,
'''   `job_title` varbinary(255) NOT NULL,
'''   `job_timestamp` varbinary(14) DEFAULT NULL,
'''   `job_params` blob NOT NULL,
'''   `job_random` int(10) unsigned NOT NULL DEFAULT '0',
'''   `job_attempts` int(10) unsigned NOT NULL DEFAULT '0',
'''   `job_token` varbinary(32) NOT NULL DEFAULT '',
'''   `job_token_timestamp` varbinary(14) DEFAULT NULL,
'''   `job_sha1` varbinary(32) NOT NULL DEFAULT '',
'''   PRIMARY KEY (`job_id`),
'''   KEY `job_sha1` (`job_sha1`),
'''   KEY `job_cmd_token` (`job_cmd`,`job_token`,`job_random`),
'''   KEY `job_cmd_token_id` (`job_cmd`,`job_token`,`job_id`),
'''   KEY `job_cmd` (`job_cmd`,`job_namespace`,`job_title`,`job_params`(128)),
'''   KEY `job_timestamp` (`job_timestamp`)
''' ) ENGINE=InnoDB DEFAULT CHARSET=binary;
''' /*!40101 SET character_set_client = @saved_cs_client */;
''' 
''' --
''' 
''' </summary>
''' <remarks></remarks>
<Oracle.LinuxCompatibility.MySQL.Reflection.DbAttributes.TableName("lib_wikijob", Database:="wiki")>
Public Class lib_wikijob: Inherits Oracle.LinuxCompatibility.MySQL.SQLTable
#Region "Public Property Mapping To Database Fields"
    <DatabaseField("job_id"), PrimaryKey, AutoIncrement, NotNull, DataType(MySqlDbType.Int64, "10")> Public Property job_id As Long
    <DatabaseField("job_cmd"), NotNull, DataType(MySqlDbType.Blob)> Public Property job_cmd As Byte()
    <DatabaseField("job_namespace"), NotNull, DataType(MySqlDbType.Int64, "11")> Public Property job_namespace As Long
    <DatabaseField("job_title"), NotNull, DataType(MySqlDbType.Blob)> Public Property job_title As Byte()
    <DatabaseField("job_timestamp"), DataType(MySqlDbType.Blob)> Public Property job_timestamp As Byte()
    <DatabaseField("job_params"), NotNull, DataType(MySqlDbType.Blob)> Public Property job_params As Byte()
    <DatabaseField("job_random"), NotNull, DataType(MySqlDbType.Int64, "10")> Public Property job_random As Long
    <DatabaseField("job_attempts"), NotNull, DataType(MySqlDbType.Int64, "10")> Public Property job_attempts As Long
    <DatabaseField("job_token"), NotNull, DataType(MySqlDbType.Blob)> Public Property job_token As Byte()
    <DatabaseField("job_token_timestamp"), DataType(MySqlDbType.Blob)> Public Property job_token_timestamp As Byte()
    <DatabaseField("job_sha1"), NotNull, DataType(MySqlDbType.Blob)> Public Property job_sha1 As Byte()
#End Region
#Region "Public SQL Interface"
#Region "Interface SQL"
    Private Shared ReadOnly INSERT_SQL As String = <SQL>INSERT INTO `lib_wikijob` (`job_cmd`, `job_namespace`, `job_title`, `job_timestamp`, `job_params`, `job_random`, `job_attempts`, `job_token`, `job_token_timestamp`, `job_sha1`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}');</SQL>
    Private Shared ReadOnly REPLACE_SQL As String = <SQL>REPLACE INTO `lib_wikijob` (`job_cmd`, `job_namespace`, `job_title`, `job_timestamp`, `job_params`, `job_random`, `job_attempts`, `job_token`, `job_token_timestamp`, `job_sha1`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}');</SQL>
    Private Shared ReadOnly DELETE_SQL As String = <SQL>DELETE FROM `lib_wikijob` WHERE `job_id` = '{0}';</SQL>
    Private Shared ReadOnly UPDATE_SQL As String = <SQL>UPDATE `lib_wikijob` SET `job_id`='{0}', `job_cmd`='{1}', `job_namespace`='{2}', `job_title`='{3}', `job_timestamp`='{4}', `job_params`='{5}', `job_random`='{6}', `job_attempts`='{7}', `job_token`='{8}', `job_token_timestamp`='{9}', `job_sha1`='{10}' WHERE `job_id` = '{11}';</SQL>
#End Region
    Public Overrides Function GetDeleteSQL() As String
        Return String.Format(DELETE_SQL, job_id)
    End Function
    Public Overrides Function GetInsertSQL() As String
        Return String.Format(INSERT_SQL, job_cmd, job_namespace, job_title, job_timestamp, job_params, job_random, job_attempts, job_token, job_token_timestamp, job_sha1)
    End Function
    Public Overrides Function GetReplaceSQL() As String
        Return String.Format(REPLACE_SQL, job_cmd, job_namespace, job_title, job_timestamp, job_params, job_random, job_attempts, job_token, job_token_timestamp, job_sha1)
    End Function
    Public Overrides Function GetUpdateSQL() As String
        Return String.Format(UPDATE_SQL, job_id, job_cmd, job_namespace, job_title, job_timestamp, job_params, job_random, job_attempts, job_token, job_token_timestamp, job_sha1, job_id)
    End Function
#End Region
End Class


End Namespace
