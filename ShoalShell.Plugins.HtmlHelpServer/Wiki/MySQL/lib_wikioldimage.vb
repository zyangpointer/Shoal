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
''' DROP TABLE IF EXISTS `lib_wikioldimage`;
''' /*!40101 SET @saved_cs_client     = @@character_set_client */;
''' /*!40101 SET character_set_client = utf8 */;
''' CREATE TABLE `lib_wikioldimage` (
'''   `oi_name` varbinary(255) NOT NULL DEFAULT '',
'''   `oi_archive_name` varbinary(255) NOT NULL DEFAULT '',
'''   `oi_size` int(10) unsigned NOT NULL DEFAULT '0',
'''   `oi_width` int(11) NOT NULL DEFAULT '0',
'''   `oi_height` int(11) NOT NULL DEFAULT '0',
'''   `oi_bits` int(11) NOT NULL DEFAULT '0',
'''   `oi_description` varbinary(767) NOT NULL,
'''   `oi_user` int(10) unsigned NOT NULL DEFAULT '0',
'''   `oi_user_text` varbinary(255) NOT NULL,
'''   `oi_timestamp` binary(14) NOT NULL DEFAULT '\0\0\0\0\0\0\0\0\0\0\0\0\0\0',
'''   `oi_metadata` mediumblob NOT NULL,
'''   `oi_media_type` enum('UNKNOWN','BITMAP','DRAWING','AUDIO','VIDEO','MULTIMEDIA','OFFICE','TEXT','EXECUTABLE','ARCHIVE') DEFAULT NULL,
'''   `oi_major_mime` enum('unknown','application','audio','image','text','video','message','model','multipart','chemical') NOT NULL DEFAULT 'unknown',
'''   `oi_minor_mime` varbinary(100) NOT NULL DEFAULT 'unknown',
'''   `oi_deleted` tinyint(3) unsigned NOT NULL DEFAULT '0',
'''   `oi_sha1` varbinary(32) NOT NULL DEFAULT '',
'''   KEY `oi_usertext_timestamp` (`oi_user_text`,`oi_timestamp`),
'''   KEY `oi_name_timestamp` (`oi_name`,`oi_timestamp`),
'''   KEY `oi_name_archive_name` (`oi_name`,`oi_archive_name`(14)),
'''   KEY `oi_sha1` (`oi_sha1`(10))
''' ) ENGINE=InnoDB DEFAULT CHARSET=binary;
''' /*!40101 SET character_set_client = @saved_cs_client */;
''' 
''' --
''' 
''' </summary>
''' <remarks></remarks>
<Oracle.LinuxCompatibility.MySQL.Reflection.DbAttributes.TableName("lib_wikioldimage", Database:="wiki")>
Public Class lib_wikioldimage: Inherits Oracle.LinuxCompatibility.MySQL.SQLTable
#Region "Public Property Mapping To Database Fields"
    <DatabaseField("oi_name"), NotNull, DataType(MySqlDbType.Blob)> Public Property oi_name As Byte()
    <DatabaseField("oi_archive_name"), NotNull, DataType(MySqlDbType.Blob)> Public Property oi_archive_name As Byte()
    <DatabaseField("oi_size"), NotNull, DataType(MySqlDbType.Int64, "10")> Public Property oi_size As Long
    <DatabaseField("oi_width"), NotNull, DataType(MySqlDbType.Int64, "11")> Public Property oi_width As Long
    <DatabaseField("oi_height"), NotNull, DataType(MySqlDbType.Int64, "11")> Public Property oi_height As Long
    <DatabaseField("oi_bits"), NotNull, DataType(MySqlDbType.Int64, "11")> Public Property oi_bits As Long
    <DatabaseField("oi_description"), NotNull, DataType(MySqlDbType.Blob)> Public Property oi_description As Byte()
    <DatabaseField("oi_user"), NotNull, DataType(MySqlDbType.Int64, "10")> Public Property oi_user As Long
    <DatabaseField("oi_user_text"), PrimaryKey, NotNull, DataType(MySqlDbType.Blob)> Public Property oi_user_text As Byte()
    <DatabaseField("oi_timestamp"), PrimaryKey, NotNull, DataType(MySqlDbType.Blob)> Public Property oi_timestamp As Byte()
    <DatabaseField("oi_metadata"), NotNull, DataType(MySqlDbType.Blob)> Public Property oi_metadata As Byte()
    <DatabaseField("oi_media_type"), DataType(MySqlDbType.Text)> Public Property oi_media_type As String
    <DatabaseField("oi_major_mime"), NotNull, DataType(MySqlDbType.Text)> Public Property oi_major_mime As String
    <DatabaseField("oi_minor_mime"), NotNull, DataType(MySqlDbType.Blob)> Public Property oi_minor_mime As Byte()
    <DatabaseField("oi_deleted"), NotNull, DataType(MySqlDbType.Int64, "3")> Public Property oi_deleted As Long
    <DatabaseField("oi_sha1"), NotNull, DataType(MySqlDbType.Blob)> Public Property oi_sha1 As Byte()
#End Region
#Region "Public SQL Interface"
#Region "Interface SQL"
    Private Shared ReadOnly INSERT_SQL As String = <SQL>INSERT INTO `lib_wikioldimage` (`oi_name`, `oi_archive_name`, `oi_size`, `oi_width`, `oi_height`, `oi_bits`, `oi_description`, `oi_user`, `oi_user_text`, `oi_timestamp`, `oi_metadata`, `oi_media_type`, `oi_major_mime`, `oi_minor_mime`, `oi_deleted`, `oi_sha1`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}', '{13}', '{14}', '{15}');</SQL>
    Private Shared ReadOnly REPLACE_SQL As String = <SQL>REPLACE INTO `lib_wikioldimage` (`oi_name`, `oi_archive_name`, `oi_size`, `oi_width`, `oi_height`, `oi_bits`, `oi_description`, `oi_user`, `oi_user_text`, `oi_timestamp`, `oi_metadata`, `oi_media_type`, `oi_major_mime`, `oi_minor_mime`, `oi_deleted`, `oi_sha1`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}', '{13}', '{14}', '{15}');</SQL>
    Private Shared ReadOnly DELETE_SQL As String = <SQL>DELETE FROM `lib_wikioldimage` WHERE `oi_user_text`='{0}' and `oi_timestamp`='{1}';</SQL>
    Private Shared ReadOnly UPDATE_SQL As String = <SQL>UPDATE `lib_wikioldimage` SET `oi_name`='{0}', `oi_archive_name`='{1}', `oi_size`='{2}', `oi_width`='{3}', `oi_height`='{4}', `oi_bits`='{5}', `oi_description`='{6}', `oi_user`='{7}', `oi_user_text`='{8}', `oi_timestamp`='{9}', `oi_metadata`='{10}', `oi_media_type`='{11}', `oi_major_mime`='{12}', `oi_minor_mime`='{13}', `oi_deleted`='{14}', `oi_sha1`='{15}' WHERE `oi_user_text`='{16}' and `oi_timestamp`='{17}';</SQL>
#End Region
    Public Overrides Function GetDeleteSQL() As String
        Return String.Format(DELETE_SQL, oi_user_text, oi_timestamp)
    End Function
    Public Overrides Function GetInsertSQL() As String
        Return String.Format(INSERT_SQL, oi_name, oi_archive_name, oi_size, oi_width, oi_height, oi_bits, oi_description, oi_user, oi_user_text, oi_timestamp, oi_metadata, oi_media_type, oi_major_mime, oi_minor_mime, oi_deleted, oi_sha1)
    End Function
    Public Overrides Function GetReplaceSQL() As String
        Return String.Format(REPLACE_SQL, oi_name, oi_archive_name, oi_size, oi_width, oi_height, oi_bits, oi_description, oi_user, oi_user_text, oi_timestamp, oi_metadata, oi_media_type, oi_major_mime, oi_minor_mime, oi_deleted, oi_sha1)
    End Function
    Public Overrides Function GetUpdateSQL() As String
        Return String.Format(UPDATE_SQL, oi_name, oi_archive_name, oi_size, oi_width, oi_height, oi_bits, oi_description, oi_user, oi_user_text, oi_timestamp, oi_metadata, oi_media_type, oi_major_mime, oi_minor_mime, oi_deleted, oi_sha1, oi_user_text, oi_timestamp)
    End Function
#End Region
End Class


End Namespace
