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
''' DROP TABLE IF EXISTS `lib_wikipage`;
''' /*!40101 SET @saved_cs_client     = @@character_set_client */;
''' /*!40101 SET character_set_client = utf8 */;
''' CREATE TABLE `lib_wikipage` (
'''   `page_id` int(10) unsigned NOT NULL AUTO_INCREMENT,
'''   `page_namespace` int(11) NOT NULL,
'''   `page_title` varbinary(255) NOT NULL,
'''   `page_restrictions` tinyblob NOT NULL,
'''   `page_is_redirect` tinyint(3) unsigned NOT NULL DEFAULT '0',
'''   `page_is_new` tinyint(3) unsigned NOT NULL DEFAULT '0',
'''   `page_random` double unsigned NOT NULL,
'''   `page_touched` binary(14) NOT NULL DEFAULT '\0\0\0\0\0\0\0\0\0\0\0\0\0\0',
'''   `page_links_updated` varbinary(14) DEFAULT NULL,
'''   `page_latest` int(10) unsigned NOT NULL,
'''   `page_len` int(10) unsigned NOT NULL,
'''   `page_content_model` varbinary(32) DEFAULT NULL,
'''   `page_lang` varbinary(35) DEFAULT NULL,
'''   PRIMARY KEY (`page_id`),
'''   UNIQUE KEY `name_title` (`page_namespace`,`page_title`),
'''   KEY `page_random` (`page_random`),
'''   KEY `page_len` (`page_len`),
'''   KEY `page_redirect_namespace_len` (`page_is_redirect`,`page_namespace`,`page_len`)
''' ) ENGINE=InnoDB DEFAULT CHARSET=binary;
''' /*!40101 SET character_set_client = @saved_cs_client */;
''' 
''' --
''' 
''' </summary>
''' <remarks></remarks>
<Oracle.LinuxCompatibility.MySQL.Reflection.DbAttributes.TableName("lib_wikipage", Database:="wiki")>
Public Class lib_wikipage: Inherits Oracle.LinuxCompatibility.MySQL.SQLTable
#Region "Public Property Mapping To Database Fields"
    <DatabaseField("page_id"), PrimaryKey, AutoIncrement, NotNull, DataType(MySqlDbType.Int64, "10")> Public Property page_id As Long
    <DatabaseField("page_namespace"), NotNull, DataType(MySqlDbType.Int64, "11")> Public Property page_namespace As Long
    <DatabaseField("page_title"), NotNull, DataType(MySqlDbType.Blob)> Public Property page_title As Byte()
    <DatabaseField("page_restrictions"), NotNull, DataType(MySqlDbType.Blob)> Public Property page_restrictions As Byte()
    <DatabaseField("page_is_redirect"), NotNull, DataType(MySqlDbType.Int64, "3")> Public Property page_is_redirect As Long
    <DatabaseField("page_is_new"), NotNull, DataType(MySqlDbType.Int64, "3")> Public Property page_is_new As Long
    <DatabaseField("page_random"), NotNull, DataType(MySqlDbType.Double)> Public Property page_random As Double
    <DatabaseField("page_touched"), NotNull, DataType(MySqlDbType.Blob)> Public Property page_touched As Byte()
    <DatabaseField("page_links_updated"), DataType(MySqlDbType.Blob)> Public Property page_links_updated As Byte()
    <DatabaseField("page_latest"), NotNull, DataType(MySqlDbType.Int64, "10")> Public Property page_latest As Long
    <DatabaseField("page_len"), NotNull, DataType(MySqlDbType.Int64, "10")> Public Property page_len As Long
    <DatabaseField("page_content_model"), DataType(MySqlDbType.Blob)> Public Property page_content_model As Byte()
    <DatabaseField("page_lang"), DataType(MySqlDbType.Blob)> Public Property page_lang As Byte()
#End Region
#Region "Public SQL Interface"
#Region "Interface SQL"
    Private Shared ReadOnly INSERT_SQL As String = <SQL>INSERT INTO `lib_wikipage` (`page_namespace`, `page_title`, `page_restrictions`, `page_is_redirect`, `page_is_new`, `page_random`, `page_touched`, `page_links_updated`, `page_latest`, `page_len`, `page_content_model`, `page_lang`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}');</SQL>
    Private Shared ReadOnly REPLACE_SQL As String = <SQL>REPLACE INTO `lib_wikipage` (`page_namespace`, `page_title`, `page_restrictions`, `page_is_redirect`, `page_is_new`, `page_random`, `page_touched`, `page_links_updated`, `page_latest`, `page_len`, `page_content_model`, `page_lang`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}');</SQL>
    Private Shared ReadOnly DELETE_SQL As String = <SQL>DELETE FROM `lib_wikipage` WHERE `page_id` = '{0}';</SQL>
    Private Shared ReadOnly UPDATE_SQL As String = <SQL>UPDATE `lib_wikipage` SET `page_id`='{0}', `page_namespace`='{1}', `page_title`='{2}', `page_restrictions`='{3}', `page_is_redirect`='{4}', `page_is_new`='{5}', `page_random`='{6}', `page_touched`='{7}', `page_links_updated`='{8}', `page_latest`='{9}', `page_len`='{10}', `page_content_model`='{11}', `page_lang`='{12}' WHERE `page_id` = '{13}';</SQL>
#End Region
    Public Overrides Function GetDeleteSQL() As String
        Return String.Format(DELETE_SQL, page_id)
    End Function
    Public Overrides Function GetInsertSQL() As String
        Return String.Format(INSERT_SQL, page_namespace, page_title, page_restrictions, page_is_redirect, page_is_new, page_random, page_touched, page_links_updated, page_latest, page_len, page_content_model, page_lang)
    End Function
    Public Overrides Function GetReplaceSQL() As String
        Return String.Format(REPLACE_SQL, page_namespace, page_title, page_restrictions, page_is_redirect, page_is_new, page_random, page_touched, page_links_updated, page_latest, page_len, page_content_model, page_lang)
    End Function
    Public Overrides Function GetUpdateSQL() As String
        Return String.Format(UPDATE_SQL, page_id, page_namespace, page_title, page_restrictions, page_is_redirect, page_is_new, page_random, page_touched, page_links_updated, page_latest, page_len, page_content_model, page_lang, page_id)
    End Function
#End Region
End Class


End Namespace
