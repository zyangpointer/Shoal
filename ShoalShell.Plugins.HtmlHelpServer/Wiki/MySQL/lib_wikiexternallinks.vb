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
''' DROP TABLE IF EXISTS `lib_wikiexternallinks`;
''' /*!40101 SET @saved_cs_client     = @@character_set_client */;
''' /*!40101 SET character_set_client = utf8 */;
''' CREATE TABLE `lib_wikiexternallinks` (
'''   `el_id` int(10) unsigned NOT NULL AUTO_INCREMENT,
'''   `el_from` int(10) unsigned NOT NULL DEFAULT '0',
'''   `el_to` blob NOT NULL,
'''   `el_index` blob NOT NULL,
'''   PRIMARY KEY (`el_id`),
'''   KEY `el_from` (`el_from`,`el_to`(40)),
'''   KEY `el_to` (`el_to`(60),`el_from`),
'''   KEY `el_index` (`el_index`(60))
''' ) ENGINE=InnoDB DEFAULT CHARSET=binary;
''' /*!40101 SET character_set_client = @saved_cs_client */;
''' 
''' --
''' 
''' </summary>
''' <remarks></remarks>
<Oracle.LinuxCompatibility.MySQL.Reflection.DbAttributes.TableName("lib_wikiexternallinks", Database:="wiki")>
Public Class lib_wikiexternallinks: Inherits Oracle.LinuxCompatibility.MySQL.SQLTable
#Region "Public Property Mapping To Database Fields"
    <DatabaseField("el_id"), PrimaryKey, AutoIncrement, NotNull, DataType(MySqlDbType.Int64, "10")> Public Property el_id As Long
    <DatabaseField("el_from"), NotNull, DataType(MySqlDbType.Int64, "10")> Public Property el_from As Long
    <DatabaseField("el_to"), NotNull, DataType(MySqlDbType.Blob)> Public Property el_to As Byte()
    <DatabaseField("el_index"), NotNull, DataType(MySqlDbType.Blob)> Public Property el_index As Byte()
#End Region
#Region "Public SQL Interface"
#Region "Interface SQL"
    Private Shared ReadOnly INSERT_SQL As String = <SQL>INSERT INTO `lib_wikiexternallinks` (`el_from`, `el_to`, `el_index`) VALUES ('{0}', '{1}', '{2}');</SQL>
    Private Shared ReadOnly REPLACE_SQL As String = <SQL>REPLACE INTO `lib_wikiexternallinks` (`el_from`, `el_to`, `el_index`) VALUES ('{0}', '{1}', '{2}');</SQL>
    Private Shared ReadOnly DELETE_SQL As String = <SQL>DELETE FROM `lib_wikiexternallinks` WHERE `el_id` = '{0}';</SQL>
    Private Shared ReadOnly UPDATE_SQL As String = <SQL>UPDATE `lib_wikiexternallinks` SET `el_id`='{0}', `el_from`='{1}', `el_to`='{2}', `el_index`='{3}' WHERE `el_id` = '{4}';</SQL>
#End Region
    Public Overrides Function GetDeleteSQL() As String
        Return String.Format(DELETE_SQL, el_id)
    End Function
    Public Overrides Function GetInsertSQL() As String
        Return String.Format(INSERT_SQL, el_from, el_to, el_index)
    End Function
    Public Overrides Function GetReplaceSQL() As String
        Return String.Format(REPLACE_SQL, el_from, el_to, el_index)
    End Function
    Public Overrides Function GetUpdateSQL() As String
        Return String.Format(UPDATE_SQL, el_id, el_from, el_to, el_index, el_id)
    End Function
#End Region
End Class


End Namespace
