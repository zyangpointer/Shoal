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
''' DROP TABLE IF EXISTS `lib_wikiuploadstash`;
''' /*!40101 SET @saved_cs_client     = @@character_set_client */;
''' /*!40101 SET character_set_client = utf8 */;
''' CREATE TABLE `lib_wikiuploadstash` (
'''   `us_id` int(10) unsigned NOT NULL AUTO_INCREMENT,
'''   `us_user` int(10) unsigned NOT NULL,
'''   `us_key` varbinary(255) NOT NULL,
'''   `us_orig_path` varbinary(255) NOT NULL,
'''   `us_path` varbinary(255) NOT NULL,
'''   `us_source_type` varbinary(50) DEFAULT NULL,
'''   `us_timestamp` varbinary(14) NOT NULL,
'''   `us_status` varbinary(50) NOT NULL,
'''   `us_chunk_inx` int(10) unsigned DEFAULT NULL,
'''   `us_props` blob,
'''   `us_size` int(10) unsigned NOT NULL,
'''   `us_sha1` varbinary(31) NOT NULL,
'''   `us_mime` varbinary(255) DEFAULT NULL,
'''   `us_media_type` enum('UNKNOWN','BITMAP','DRAWING','AUDIO','VIDEO','MULTIMEDIA','OFFICE','TEXT','EXECUTABLE','ARCHIVE') DEFAULT NULL,
'''   `us_image_width` int(10) unsigned DEFAULT NULL,
'''   `us_image_height` int(10) unsigned DEFAULT NULL,
'''   `us_image_bits` smallint(5) unsigned DEFAULT NULL,
'''   PRIMARY KEY (`us_id`),
'''   UNIQUE KEY `us_key` (`us_key`),
'''   KEY `us_user` (`us_user`),
'''   KEY `us_timestamp` (`us_timestamp`)
''' ) ENGINE=InnoDB DEFAULT CHARSET=binary;
''' /*!40101 SET character_set_client = @saved_cs_client */;
''' 
''' --
''' 
''' </summary>
''' <remarks></remarks>
<Oracle.LinuxCompatibility.MySQL.Reflection.DbAttributes.TableName("lib_wikiuploadstash", Database:="wiki")>
Public Class lib_wikiuploadstash: Inherits Oracle.LinuxCompatibility.MySQL.SQLTable
#Region "Public Property Mapping To Database Fields"
    <DatabaseField("us_id"), PrimaryKey, AutoIncrement, NotNull, DataType(MySqlDbType.Int64, "10")> Public Property us_id As Long
    <DatabaseField("us_user"), NotNull, DataType(MySqlDbType.Int64, "10")> Public Property us_user As Long
    <DatabaseField("us_key"), NotNull, DataType(MySqlDbType.Blob)> Public Property us_key As Byte()
    <DatabaseField("us_orig_path"), NotNull, DataType(MySqlDbType.Blob)> Public Property us_orig_path As Byte()
    <DatabaseField("us_path"), NotNull, DataType(MySqlDbType.Blob)> Public Property us_path As Byte()
    <DatabaseField("us_source_type"), DataType(MySqlDbType.Blob)> Public Property us_source_type As Byte()
    <DatabaseField("us_timestamp"), NotNull, DataType(MySqlDbType.Blob)> Public Property us_timestamp As Byte()
    <DatabaseField("us_status"), NotNull, DataType(MySqlDbType.Blob)> Public Property us_status As Byte()
    <DatabaseField("us_chunk_inx"), DataType(MySqlDbType.Int64, "10")> Public Property us_chunk_inx As Long
    <DatabaseField("us_props"), DataType(MySqlDbType.Blob)> Public Property us_props As Byte()
    <DatabaseField("us_size"), NotNull, DataType(MySqlDbType.Int64, "10")> Public Property us_size As Long
    <DatabaseField("us_sha1"), NotNull, DataType(MySqlDbType.Blob)> Public Property us_sha1 As Byte()
    <DatabaseField("us_mime"), DataType(MySqlDbType.Blob)> Public Property us_mime As Byte()
    <DatabaseField("us_media_type"), DataType(MySqlDbType.Text)> Public Property us_media_type As String
    <DatabaseField("us_image_width"), DataType(MySqlDbType.Int64, "10")> Public Property us_image_width As Long
    <DatabaseField("us_image_height"), DataType(MySqlDbType.Int64, "10")> Public Property us_image_height As Long
    <DatabaseField("us_image_bits"), DataType(MySqlDbType.Int64, "5")> Public Property us_image_bits As Long
#End Region
#Region "Public SQL Interface"
#Region "Interface SQL"
    Private Shared ReadOnly INSERT_SQL As String = <SQL>INSERT INTO `lib_wikiuploadstash` (`us_user`, `us_key`, `us_orig_path`, `us_path`, `us_source_type`, `us_timestamp`, `us_status`, `us_chunk_inx`, `us_props`, `us_size`, `us_sha1`, `us_mime`, `us_media_type`, `us_image_width`, `us_image_height`, `us_image_bits`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}', '{13}', '{14}', '{15}');</SQL>
    Private Shared ReadOnly REPLACE_SQL As String = <SQL>REPLACE INTO `lib_wikiuploadstash` (`us_user`, `us_key`, `us_orig_path`, `us_path`, `us_source_type`, `us_timestamp`, `us_status`, `us_chunk_inx`, `us_props`, `us_size`, `us_sha1`, `us_mime`, `us_media_type`, `us_image_width`, `us_image_height`, `us_image_bits`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}', '{13}', '{14}', '{15}');</SQL>
    Private Shared ReadOnly DELETE_SQL As String = <SQL>DELETE FROM `lib_wikiuploadstash` WHERE `us_id` = '{0}';</SQL>
    Private Shared ReadOnly UPDATE_SQL As String = <SQL>UPDATE `lib_wikiuploadstash` SET `us_id`='{0}', `us_user`='{1}', `us_key`='{2}', `us_orig_path`='{3}', `us_path`='{4}', `us_source_type`='{5}', `us_timestamp`='{6}', `us_status`='{7}', `us_chunk_inx`='{8}', `us_props`='{9}', `us_size`='{10}', `us_sha1`='{11}', `us_mime`='{12}', `us_media_type`='{13}', `us_image_width`='{14}', `us_image_height`='{15}', `us_image_bits`='{16}' WHERE `us_id` = '{17}';</SQL>
#End Region
    Public Overrides Function GetDeleteSQL() As String
        Return String.Format(DELETE_SQL, us_id)
    End Function
    Public Overrides Function GetInsertSQL() As String
        Return String.Format(INSERT_SQL, us_user, us_key, us_orig_path, us_path, us_source_type, us_timestamp, us_status, us_chunk_inx, us_props, us_size, us_sha1, us_mime, us_media_type, us_image_width, us_image_height, us_image_bits)
    End Function
    Public Overrides Function GetReplaceSQL() As String
        Return String.Format(REPLACE_SQL, us_user, us_key, us_orig_path, us_path, us_source_type, us_timestamp, us_status, us_chunk_inx, us_props, us_size, us_sha1, us_mime, us_media_type, us_image_width, us_image_height, us_image_bits)
    End Function
    Public Overrides Function GetUpdateSQL() As String
        Return String.Format(UPDATE_SQL, us_id, us_user, us_key, us_orig_path, us_path, us_source_type, us_timestamp, us_status, us_chunk_inx, us_props, us_size, us_sha1, us_mime, us_media_type, us_image_width, us_image_height, us_image_bits, us_id)
    End Function
#End Region
End Class


End Namespace
