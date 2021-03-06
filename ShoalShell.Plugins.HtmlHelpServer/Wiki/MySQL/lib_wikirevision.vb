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
''' DROP TABLE IF EXISTS `lib_wikirevision`;
''' /*!40101 SET @saved_cs_client     = @@character_set_client */;
''' /*!40101 SET character_set_client = utf8 */;
''' CREATE TABLE `lib_wikirevision` (
'''   `rev_id` int(10) unsigned NOT NULL AUTO_INCREMENT,
'''   `rev_page` int(10) unsigned NOT NULL,
'''   `rev_text_id` int(10) unsigned NOT NULL,
'''   `rev_comment` varbinary(767) NOT NULL,
'''   `rev_user` int(10) unsigned NOT NULL DEFAULT '0',
'''   `rev_user_text` varbinary(255) NOT NULL DEFAULT '',
'''   `rev_timestamp` binary(14) NOT NULL DEFAULT '\0\0\0\0\0\0\0\0\0\0\0\0\0\0',
'''   `rev_minor_edit` tinyint(3) unsigned NOT NULL DEFAULT '0',
'''   `rev_deleted` tinyint(3) unsigned NOT NULL DEFAULT '0',
'''   `rev_len` int(10) unsigned DEFAULT NULL,
'''   `rev_parent_id` int(10) unsigned DEFAULT NULL,
'''   `rev_sha1` varbinary(32) NOT NULL DEFAULT '',
'''   `rev_content_model` varbinary(32) DEFAULT NULL,
'''   `rev_content_format` varbinary(64) DEFAULT NULL,
'''   PRIMARY KEY (`rev_id`),
'''   UNIQUE KEY `rev_page_id` (`rev_page`,`rev_id`),
'''   KEY `rev_timestamp` (`rev_timestamp`),
'''   KEY `page_timestamp` (`rev_page`,`rev_timestamp`),
'''   KEY `user_timestamp` (`rev_user`,`rev_timestamp`),
'''   KEY `usertext_timestamp` (`rev_user_text`,`rev_timestamp`),
'''   KEY `page_user_timestamp` (`rev_page`,`rev_user`,`rev_timestamp`)
''' ) ENGINE=InnoDB DEFAULT CHARSET=binary MAX_ROWS=10000000 AVG_ROW_LENGTH=1024;
''' /*!40101 SET character_set_client = @saved_cs_client */;
''' 
''' --
''' 
''' </summary>
''' <remarks></remarks>
<Oracle.LinuxCompatibility.MySQL.Reflection.DbAttributes.TableName("lib_wikirevision", Database:="wiki")>
Public Class lib_wikirevision: Inherits Oracle.LinuxCompatibility.MySQL.SQLTable
#Region "Public Property Mapping To Database Fields"
    <DatabaseField("rev_id"), PrimaryKey, AutoIncrement, NotNull, DataType(MySqlDbType.Int64, "10")> Public Property rev_id As Long
    <DatabaseField("rev_page"), NotNull, DataType(MySqlDbType.Int64, "10")> Public Property rev_page As Long
    <DatabaseField("rev_text_id"), NotNull, DataType(MySqlDbType.Int64, "10")> Public Property rev_text_id As Long
    <DatabaseField("rev_comment"), NotNull, DataType(MySqlDbType.Blob)> Public Property rev_comment As Byte()
    <DatabaseField("rev_user"), NotNull, DataType(MySqlDbType.Int64, "10")> Public Property rev_user As Long
    <DatabaseField("rev_user_text"), NotNull, DataType(MySqlDbType.Blob)> Public Property rev_user_text As Byte()
    <DatabaseField("rev_timestamp"), NotNull, DataType(MySqlDbType.Blob)> Public Property rev_timestamp As Byte()
    <DatabaseField("rev_minor_edit"), NotNull, DataType(MySqlDbType.Int64, "3")> Public Property rev_minor_edit As Long
    <DatabaseField("rev_deleted"), NotNull, DataType(MySqlDbType.Int64, "3")> Public Property rev_deleted As Long
    <DatabaseField("rev_len"), DataType(MySqlDbType.Int64, "10")> Public Property rev_len As Long
    <DatabaseField("rev_parent_id"), DataType(MySqlDbType.Int64, "10")> Public Property rev_parent_id As Long
    <DatabaseField("rev_sha1"), NotNull, DataType(MySqlDbType.Blob)> Public Property rev_sha1 As Byte()
    <DatabaseField("rev_content_model"), DataType(MySqlDbType.Blob)> Public Property rev_content_model As Byte()
    <DatabaseField("rev_content_format"), DataType(MySqlDbType.Blob)> Public Property rev_content_format As Byte()
#End Region
#Region "Public SQL Interface"
#Region "Interface SQL"
    Private Shared ReadOnly INSERT_SQL As String = <SQL>INSERT INTO `lib_wikirevision` (`rev_page`, `rev_text_id`, `rev_comment`, `rev_user`, `rev_user_text`, `rev_timestamp`, `rev_minor_edit`, `rev_deleted`, `rev_len`, `rev_parent_id`, `rev_sha1`, `rev_content_model`, `rev_content_format`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}');</SQL>
    Private Shared ReadOnly REPLACE_SQL As String = <SQL>REPLACE INTO `lib_wikirevision` (`rev_page`, `rev_text_id`, `rev_comment`, `rev_user`, `rev_user_text`, `rev_timestamp`, `rev_minor_edit`, `rev_deleted`, `rev_len`, `rev_parent_id`, `rev_sha1`, `rev_content_model`, `rev_content_format`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}');</SQL>
    Private Shared ReadOnly DELETE_SQL As String = <SQL>DELETE FROM `lib_wikirevision` WHERE `rev_id` = '{0}';</SQL>
    Private Shared ReadOnly UPDATE_SQL As String = <SQL>UPDATE `lib_wikirevision` SET `rev_id`='{0}', `rev_page`='{1}', `rev_text_id`='{2}', `rev_comment`='{3}', `rev_user`='{4}', `rev_user_text`='{5}', `rev_timestamp`='{6}', `rev_minor_edit`='{7}', `rev_deleted`='{8}', `rev_len`='{9}', `rev_parent_id`='{10}', `rev_sha1`='{11}', `rev_content_model`='{12}', `rev_content_format`='{13}' WHERE `rev_id` = '{14}';</SQL>
#End Region
    Public Overrides Function GetDeleteSQL() As String
        Return String.Format(DELETE_SQL, rev_id)
    End Function
    Public Overrides Function GetInsertSQL() As String
        Return String.Format(INSERT_SQL, rev_page, rev_text_id, rev_comment, rev_user, rev_user_text, rev_timestamp, rev_minor_edit, rev_deleted, rev_len, rev_parent_id, rev_sha1, rev_content_model, rev_content_format)
    End Function
    Public Overrides Function GetReplaceSQL() As String
        Return String.Format(REPLACE_SQL, rev_page, rev_text_id, rev_comment, rev_user, rev_user_text, rev_timestamp, rev_minor_edit, rev_deleted, rev_len, rev_parent_id, rev_sha1, rev_content_model, rev_content_format)
    End Function
    Public Overrides Function GetUpdateSQL() As String
        Return String.Format(UPDATE_SQL, rev_id, rev_page, rev_text_id, rev_comment, rev_user, rev_user_text, rev_timestamp, rev_minor_edit, rev_deleted, rev_len, rev_parent_id, rev_sha1, rev_content_model, rev_content_format, rev_id)
    End Function
#End Region
End Class


End Namespace
