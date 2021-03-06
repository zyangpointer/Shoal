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
''' DROP TABLE IF EXISTS `lib_wikiimage`;
''' /*!40101 SET @saved_cs_client     = @@character_set_client */;
''' /*!40101 SET character_set_client = utf8 */;
''' CREATE TABLE `lib_wikiimage` (
'''   `img_name` varbinary(255) NOT NULL DEFAULT '',
'''   `img_size` int(10) unsigned NOT NULL DEFAULT '0',
'''   `img_width` int(11) NOT NULL DEFAULT '0',
'''   `img_height` int(11) NOT NULL DEFAULT '0',
'''   `img_metadata` mediumblob NOT NULL,
'''   `img_bits` int(11) NOT NULL DEFAULT '0',
'''   `img_media_type` enum('UNKNOWN','BITMAP','DRAWING','AUDIO','VIDEO','MULTIMEDIA','OFFICE','TEXT','EXECUTABLE','ARCHIVE') DEFAULT NULL,
'''   `img_major_mime` enum('unknown','application','audio','image','text','video','message','model','multipart','chemical') NOT NULL DEFAULT 'unknown',
'''   `img_minor_mime` varbinary(100) NOT NULL DEFAULT 'unknown',
'''   `img_description` varbinary(767) NOT NULL,
'''   `img_user` int(10) unsigned NOT NULL DEFAULT '0',
'''   `img_user_text` varbinary(255) NOT NULL,
'''   `img_timestamp` varbinary(14) NOT NULL DEFAULT '',
'''   `img_sha1` varbinary(32) NOT NULL DEFAULT '',
'''   PRIMARY KEY (`img_name`),
'''   KEY `img_usertext_timestamp` (`img_user_text`,`img_timestamp`),
'''   KEY `img_size` (`img_size`),
'''   KEY `img_timestamp` (`img_timestamp`),
'''   KEY `img_sha1` (`img_sha1`(10)),
'''   KEY `img_media_mime` (`img_media_type`,`img_major_mime`,`img_minor_mime`)
''' ) ENGINE=InnoDB DEFAULT CHARSET=binary;
''' /*!40101 SET character_set_client = @saved_cs_client */;
''' 
''' --
''' 
''' </summary>
''' <remarks></remarks>
<Oracle.LinuxCompatibility.MySQL.Reflection.DbAttributes.TableName("lib_wikiimage", Database:="wiki")>
Public Class lib_wikiimage: Inherits Oracle.LinuxCompatibility.MySQL.SQLTable
#Region "Public Property Mapping To Database Fields"
    <DatabaseField("img_name"), PrimaryKey, NotNull, DataType(MySqlDbType.Blob)> Public Property img_name As Byte()
    <DatabaseField("img_size"), NotNull, DataType(MySqlDbType.Int64, "10")> Public Property img_size As Long
    <DatabaseField("img_width"), NotNull, DataType(MySqlDbType.Int64, "11")> Public Property img_width As Long
    <DatabaseField("img_height"), NotNull, DataType(MySqlDbType.Int64, "11")> Public Property img_height As Long
    <DatabaseField("img_metadata"), NotNull, DataType(MySqlDbType.Blob)> Public Property img_metadata As Byte()
    <DatabaseField("img_bits"), NotNull, DataType(MySqlDbType.Int64, "11")> Public Property img_bits As Long
    <DatabaseField("img_media_type"), DataType(MySqlDbType.Text)> Public Property img_media_type As String
    <DatabaseField("img_major_mime"), NotNull, DataType(MySqlDbType.Text)> Public Property img_major_mime As String
    <DatabaseField("img_minor_mime"), NotNull, DataType(MySqlDbType.Blob)> Public Property img_minor_mime As Byte()
    <DatabaseField("img_description"), NotNull, DataType(MySqlDbType.Blob)> Public Property img_description As Byte()
    <DatabaseField("img_user"), NotNull, DataType(MySqlDbType.Int64, "10")> Public Property img_user As Long
    <DatabaseField("img_user_text"), NotNull, DataType(MySqlDbType.Blob)> Public Property img_user_text As Byte()
    <DatabaseField("img_timestamp"), NotNull, DataType(MySqlDbType.Blob)> Public Property img_timestamp As Byte()
    <DatabaseField("img_sha1"), NotNull, DataType(MySqlDbType.Blob)> Public Property img_sha1 As Byte()
#End Region
#Region "Public SQL Interface"
#Region "Interface SQL"
    Private Shared ReadOnly INSERT_SQL As String = <SQL>INSERT INTO `lib_wikiimage` (`img_name`, `img_size`, `img_width`, `img_height`, `img_metadata`, `img_bits`, `img_media_type`, `img_major_mime`, `img_minor_mime`, `img_description`, `img_user`, `img_user_text`, `img_timestamp`, `img_sha1`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}', '{13}');</SQL>
    Private Shared ReadOnly REPLACE_SQL As String = <SQL>REPLACE INTO `lib_wikiimage` (`img_name`, `img_size`, `img_width`, `img_height`, `img_metadata`, `img_bits`, `img_media_type`, `img_major_mime`, `img_minor_mime`, `img_description`, `img_user`, `img_user_text`, `img_timestamp`, `img_sha1`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}', '{13}');</SQL>
    Private Shared ReadOnly DELETE_SQL As String = <SQL>DELETE FROM `lib_wikiimage` WHERE `img_name` = '{0}';</SQL>
    Private Shared ReadOnly UPDATE_SQL As String = <SQL>UPDATE `lib_wikiimage` SET `img_name`='{0}', `img_size`='{1}', `img_width`='{2}', `img_height`='{3}', `img_metadata`='{4}', `img_bits`='{5}', `img_media_type`='{6}', `img_major_mime`='{7}', `img_minor_mime`='{8}', `img_description`='{9}', `img_user`='{10}', `img_user_text`='{11}', `img_timestamp`='{12}', `img_sha1`='{13}' WHERE `img_name` = '{14}';</SQL>
#End Region
    Public Overrides Function GetDeleteSQL() As String
        Return String.Format(DELETE_SQL, img_name)
    End Function
    Public Overrides Function GetInsertSQL() As String
        Return String.Format(INSERT_SQL, img_name, img_size, img_width, img_height, img_metadata, img_bits, img_media_type, img_major_mime, img_minor_mime, img_description, img_user, img_user_text, img_timestamp, img_sha1)
    End Function
    Public Overrides Function GetReplaceSQL() As String
        Return String.Format(REPLACE_SQL, img_name, img_size, img_width, img_height, img_metadata, img_bits, img_media_type, img_major_mime, img_minor_mime, img_description, img_user, img_user_text, img_timestamp, img_sha1)
    End Function
    Public Overrides Function GetUpdateSQL() As String
        Return String.Format(UPDATE_SQL, img_name, img_size, img_width, img_height, img_metadata, img_bits, img_media_type, img_major_mime, img_minor_mime, img_description, img_user, img_user_text, img_timestamp, img_sha1, img_name)
    End Function
#End Region
End Class


End Namespace
