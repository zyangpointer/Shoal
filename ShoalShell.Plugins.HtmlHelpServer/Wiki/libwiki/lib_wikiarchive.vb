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
''' DROP TABLE IF EXISTS `lib_wikiarchive`;
''' /*!40101 SET @saved_cs_client     = @@character_set_client */;
''' /*!40101 SET character_set_client = utf8 */;
''' CREATE TABLE `lib_wikiarchive` (
'''   `ar_id` int(10) unsigned NOT NULL AUTO_INCREMENT,
'''   `ar_namespace` int(11) NOT NULL DEFAULT '0',
'''   `ar_title` varbinary(255) NOT NULL DEFAULT '',
'''   `ar_text` mediumblob NOT NULL,
'''   `ar_comment` varbinary(767) NOT NULL,
'''   `ar_user` int(10) unsigned NOT NULL DEFAULT '0',
'''   `ar_user_text` varbinary(255) NOT NULL,
'''   `ar_timestamp` binary(14) NOT NULL DEFAULT '\0\0\0\0\0\0\0\0\0\0\0\0\0\0',
'''   `ar_minor_edit` tinyint(4) NOT NULL DEFAULT '0',
'''   `ar_flags` tinyblob NOT NULL,
'''   `ar_rev_id` int(10) unsigned DEFAULT NULL,
'''   `ar_text_id` int(10) unsigned DEFAULT NULL,
'''   `ar_deleted` tinyint(3) unsigned NOT NULL DEFAULT '0',
'''   `ar_len` int(10) unsigned DEFAULT NULL,
'''   `ar_page_id` int(10) unsigned DEFAULT NULL,
'''   `ar_parent_id` int(10) unsigned DEFAULT NULL,
'''   `ar_sha1` varbinary(32) NOT NULL DEFAULT '',
'''   `ar_content_model` varbinary(32) DEFAULT NULL,
'''   `ar_content_format` varbinary(64) DEFAULT NULL,
'''   PRIMARY KEY (`ar_id`),
'''   KEY `name_title_timestamp` (`ar_namespace`,`ar_title`,`ar_timestamp`),
'''   KEY `usertext_timestamp` (`ar_user_text`,`ar_timestamp`),
'''   KEY `ar_revid` (`ar_rev_id`)
''' ) ENGINE=InnoDB DEFAULT CHARSET=binary;
''' /*!40101 SET character_set_client = @saved_cs_client */;
''' 
''' --
''' 
''' </summary>
''' <remarks></remarks>
<Oracle.LinuxCompatibility.MySQL.Reflection.DbAttributes.TableName("lib_wikiarchive", Database:="wiki")>
Public Class lib_wikiarchive: Inherits Oracle.LinuxCompatibility.MySQL.SQLTable
#Region "Public Property Mapping To Database Fields"
    <DatabaseField("ar_id"), PrimaryKey, AutoIncrement, NotNull, DataType(MySqlDbType.Int64, "10")> Public Property ar_id As Long
    <DatabaseField("ar_namespace"), NotNull, DataType(MySqlDbType.Int64, "11")> Public Property ar_namespace As Long
    <DatabaseField("ar_title"), NotNull, DataType(MySqlDbType.Blob)> Public Property ar_title As Byte()
    <DatabaseField("ar_text"), NotNull, DataType(MySqlDbType.Blob)> Public Property ar_text As Byte()
    <DatabaseField("ar_comment"), NotNull, DataType(MySqlDbType.Blob)> Public Property ar_comment As Byte()
    <DatabaseField("ar_user"), NotNull, DataType(MySqlDbType.Int64, "10")> Public Property ar_user As Long
    <DatabaseField("ar_user_text"), NotNull, DataType(MySqlDbType.Blob)> Public Property ar_user_text As Byte()
    <DatabaseField("ar_timestamp"), NotNull, DataType(MySqlDbType.Blob)> Public Property ar_timestamp As Byte()
    <DatabaseField("ar_minor_edit"), NotNull, DataType(MySqlDbType.Int64, "4")> Public Property ar_minor_edit As Long
    <DatabaseField("ar_flags"), NotNull, DataType(MySqlDbType.Blob)> Public Property ar_flags As Byte()
    <DatabaseField("ar_rev_id"), DataType(MySqlDbType.Int64, "10")> Public Property ar_rev_id As Long
    <DatabaseField("ar_text_id"), DataType(MySqlDbType.Int64, "10")> Public Property ar_text_id As Long
    <DatabaseField("ar_deleted"), NotNull, DataType(MySqlDbType.Int64, "3")> Public Property ar_deleted As Long
    <DatabaseField("ar_len"), DataType(MySqlDbType.Int64, "10")> Public Property ar_len As Long
    <DatabaseField("ar_page_id"), DataType(MySqlDbType.Int64, "10")> Public Property ar_page_id As Long
    <DatabaseField("ar_parent_id"), DataType(MySqlDbType.Int64, "10")> Public Property ar_parent_id As Long
    <DatabaseField("ar_sha1"), NotNull, DataType(MySqlDbType.Blob)> Public Property ar_sha1 As Byte()
    <DatabaseField("ar_content_model"), DataType(MySqlDbType.Blob)> Public Property ar_content_model As Byte()
    <DatabaseField("ar_content_format"), DataType(MySqlDbType.Blob)> Public Property ar_content_format As Byte()
#End Region
#Region "Public SQL Interface"
#Region "Interface SQL"
    Private Shared ReadOnly INSERT_SQL As String = <SQL>INSERT INTO `lib_wikiarchive` (`ar_namespace`, `ar_title`, `ar_text`, `ar_comment`, `ar_user`, `ar_user_text`, `ar_timestamp`, `ar_minor_edit`, `ar_flags`, `ar_rev_id`, `ar_text_id`, `ar_deleted`, `ar_len`, `ar_page_id`, `ar_parent_id`, `ar_sha1`, `ar_content_model`, `ar_content_format`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}', '{13}', '{14}', '{15}', '{16}', '{17}');</SQL>
    Private Shared ReadOnly REPLACE_SQL As String = <SQL>REPLACE INTO `lib_wikiarchive` (`ar_namespace`, `ar_title`, `ar_text`, `ar_comment`, `ar_user`, `ar_user_text`, `ar_timestamp`, `ar_minor_edit`, `ar_flags`, `ar_rev_id`, `ar_text_id`, `ar_deleted`, `ar_len`, `ar_page_id`, `ar_parent_id`, `ar_sha1`, `ar_content_model`, `ar_content_format`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}', '{13}', '{14}', '{15}', '{16}', '{17}');</SQL>
    Private Shared ReadOnly DELETE_SQL As String = <SQL>DELETE FROM `lib_wikiarchive` WHERE `ar_id` = '{0}';</SQL>
    Private Shared ReadOnly UPDATE_SQL As String = <SQL>UPDATE `lib_wikiarchive` SET `ar_id`='{0}', `ar_namespace`='{1}', `ar_title`='{2}', `ar_text`='{3}', `ar_comment`='{4}', `ar_user`='{5}', `ar_user_text`='{6}', `ar_timestamp`='{7}', `ar_minor_edit`='{8}', `ar_flags`='{9}', `ar_rev_id`='{10}', `ar_text_id`='{11}', `ar_deleted`='{12}', `ar_len`='{13}', `ar_page_id`='{14}', `ar_parent_id`='{15}', `ar_sha1`='{16}', `ar_content_model`='{17}', `ar_content_format`='{18}' WHERE `ar_id` = '{19}';</SQL>
#End Region
    Public Overrides Function GetDeleteSQL() As String
        Return String.Format(DELETE_SQL, ar_id)
    End Function
    Public Overrides Function GetInsertSQL() As String
        Return String.Format(INSERT_SQL, ar_namespace, ar_title, ar_text, ar_comment, ar_user, ar_user_text, ar_timestamp, ar_minor_edit, ar_flags, ar_rev_id, ar_text_id, ar_deleted, ar_len, ar_page_id, ar_parent_id, ar_sha1, ar_content_model, ar_content_format)
    End Function
    Public Overrides Function GetReplaceSQL() As String
        Return String.Format(REPLACE_SQL, ar_namespace, ar_title, ar_text, ar_comment, ar_user, ar_user_text, ar_timestamp, ar_minor_edit, ar_flags, ar_rev_id, ar_text_id, ar_deleted, ar_len, ar_page_id, ar_parent_id, ar_sha1, ar_content_model, ar_content_format)
    End Function
    Public Overrides Function GetUpdateSQL() As String
        Return String.Format(UPDATE_SQL, ar_id, ar_namespace, ar_title, ar_text, ar_comment, ar_user, ar_user_text, ar_timestamp, ar_minor_edit, ar_flags, ar_rev_id, ar_text_id, ar_deleted, ar_len, ar_page_id, ar_parent_id, ar_sha1, ar_content_model, ar_content_format, ar_id)
    End Function
#End Region
End Class


End Namespace
