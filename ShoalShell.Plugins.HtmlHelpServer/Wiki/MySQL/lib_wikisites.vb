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
''' DROP TABLE IF EXISTS `lib_wikisites`;
''' /*!40101 SET @saved_cs_client     = @@character_set_client */;
''' /*!40101 SET character_set_client = utf8 */;
''' CREATE TABLE `lib_wikisites` (
'''   `site_id` int(10) unsigned NOT NULL AUTO_INCREMENT,
'''   `site_global_key` varbinary(32) NOT NULL,
'''   `site_type` varbinary(32) NOT NULL,
'''   `site_group` varbinary(32) NOT NULL,
'''   `site_source` varbinary(32) NOT NULL,
'''   `site_language` varbinary(32) NOT NULL,
'''   `site_protocol` varbinary(32) NOT NULL,
'''   `site_domain` varbinary(255) NOT NULL,
'''   `site_data` blob NOT NULL,
'''   `site_forward` tinyint(1) NOT NULL,
'''   `site_config` blob NOT NULL,
'''   PRIMARY KEY (`site_id`),
'''   UNIQUE KEY `sites_global_key` (`site_global_key`),
'''   KEY `sites_type` (`site_type`),
'''   KEY `sites_group` (`site_group`),
'''   KEY `sites_source` (`site_source`),
'''   KEY `sites_language` (`site_language`),
'''   KEY `sites_protocol` (`site_protocol`),
'''   KEY `sites_domain` (`site_domain`),
'''   KEY `sites_forward` (`site_forward`)
''' ) ENGINE=InnoDB DEFAULT CHARSET=binary;
''' /*!40101 SET character_set_client = @saved_cs_client */;
''' 
''' --
''' 
''' </summary>
''' <remarks></remarks>
<Oracle.LinuxCompatibility.MySQL.Reflection.DbAttributes.TableName("lib_wikisites", Database:="wiki")>
Public Class lib_wikisites: Inherits Oracle.LinuxCompatibility.MySQL.SQLTable
#Region "Public Property Mapping To Database Fields"
    <DatabaseField("site_id"), PrimaryKey, AutoIncrement, NotNull, DataType(MySqlDbType.Int64, "10")> Public Property site_id As Long
    <DatabaseField("site_global_key"), NotNull, DataType(MySqlDbType.Blob)> Public Property site_global_key As Byte()
    <DatabaseField("site_type"), NotNull, DataType(MySqlDbType.Blob)> Public Property site_type As Byte()
    <DatabaseField("site_group"), NotNull, DataType(MySqlDbType.Blob)> Public Property site_group As Byte()
    <DatabaseField("site_source"), NotNull, DataType(MySqlDbType.Blob)> Public Property site_source As Byte()
    <DatabaseField("site_language"), NotNull, DataType(MySqlDbType.Blob)> Public Property site_language As Byte()
    <DatabaseField("site_protocol"), NotNull, DataType(MySqlDbType.Blob)> Public Property site_protocol As Byte()
    <DatabaseField("site_domain"), NotNull, DataType(MySqlDbType.Blob)> Public Property site_domain As Byte()
    <DatabaseField("site_data"), NotNull, DataType(MySqlDbType.Blob)> Public Property site_data As Byte()
    <DatabaseField("site_forward"), NotNull, DataType(MySqlDbType.Int64, "1")> Public Property site_forward As Long
    <DatabaseField("site_config"), NotNull, DataType(MySqlDbType.Blob)> Public Property site_config As Byte()
#End Region
#Region "Public SQL Interface"
#Region "Interface SQL"
    Private Shared ReadOnly INSERT_SQL As String = <SQL>INSERT INTO `lib_wikisites` (`site_global_key`, `site_type`, `site_group`, `site_source`, `site_language`, `site_protocol`, `site_domain`, `site_data`, `site_forward`, `site_config`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}');</SQL>
    Private Shared ReadOnly REPLACE_SQL As String = <SQL>REPLACE INTO `lib_wikisites` (`site_global_key`, `site_type`, `site_group`, `site_source`, `site_language`, `site_protocol`, `site_domain`, `site_data`, `site_forward`, `site_config`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}');</SQL>
    Private Shared ReadOnly DELETE_SQL As String = <SQL>DELETE FROM `lib_wikisites` WHERE `site_id` = '{0}';</SQL>
    Private Shared ReadOnly UPDATE_SQL As String = <SQL>UPDATE `lib_wikisites` SET `site_id`='{0}', `site_global_key`='{1}', `site_type`='{2}', `site_group`='{3}', `site_source`='{4}', `site_language`='{5}', `site_protocol`='{6}', `site_domain`='{7}', `site_data`='{8}', `site_forward`='{9}', `site_config`='{10}' WHERE `site_id` = '{11}';</SQL>
#End Region
    Public Overrides Function GetDeleteSQL() As String
        Return String.Format(DELETE_SQL, site_id)
    End Function
    Public Overrides Function GetInsertSQL() As String
        Return String.Format(INSERT_SQL, site_global_key, site_type, site_group, site_source, site_language, site_protocol, site_domain, site_data, site_forward, site_config)
    End Function
    Public Overrides Function GetReplaceSQL() As String
        Return String.Format(REPLACE_SQL, site_global_key, site_type, site_group, site_source, site_language, site_protocol, site_domain, site_data, site_forward, site_config)
    End Function
    Public Overrides Function GetUpdateSQL() As String
        Return String.Format(UPDATE_SQL, site_id, site_global_key, site_type, site_group, site_source, site_language, site_protocol, site_domain, site_data, site_forward, site_config, site_id)
    End Function
#End Region
End Class


End Namespace
