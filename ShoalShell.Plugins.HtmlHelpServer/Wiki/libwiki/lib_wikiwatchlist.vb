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
''' DROP TABLE IF EXISTS `lib_wikiwatchlist`;
''' /*!40101 SET @saved_cs_client     = @@character_set_client */;
''' /*!40101 SET character_set_client = utf8 */;
''' CREATE TABLE `lib_wikiwatchlist` (
'''   `wl_user` int(10) unsigned NOT NULL,
'''   `wl_namespace` int(11) NOT NULL DEFAULT '0',
'''   `wl_title` varbinary(255) NOT NULL DEFAULT '',
'''   `wl_notificationtimestamp` varbinary(14) DEFAULT NULL,
'''   UNIQUE KEY `wl_user` (`wl_user`,`wl_namespace`,`wl_title`),
'''   KEY `namespace_title` (`wl_namespace`,`wl_title`),
'''   KEY `wl_user_notificationtimestamp` (`wl_user`,`wl_notificationtimestamp`)
''' ) ENGINE=InnoDB DEFAULT CHARSET=binary;
''' /*!40101 SET character_set_client = @saved_cs_client */;
''' /*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;
''' 
''' /*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
''' /*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
''' /*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
''' /*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
''' /*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
''' /*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
''' /*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
''' 
''' -- Dump completed on 2015-12-03 20:20:08
''' 
''' </summary>
''' <remarks></remarks>
<Oracle.LinuxCompatibility.MySQL.Reflection.DbAttributes.TableName("lib_wikiwatchlist", Database:="wiki")>
Public Class lib_wikiwatchlist: Inherits Oracle.LinuxCompatibility.MySQL.SQLTable
#Region "Public Property Mapping To Database Fields"
    <DatabaseField("wl_user"), PrimaryKey, NotNull, DataType(MySqlDbType.Int64, "10")> Public Property wl_user As Long
    <DatabaseField("wl_namespace"), PrimaryKey, NotNull, DataType(MySqlDbType.Int64, "11")> Public Property wl_namespace As Long
    <DatabaseField("wl_title"), PrimaryKey, NotNull, DataType(MySqlDbType.Blob)> Public Property wl_title As Byte()
    <DatabaseField("wl_notificationtimestamp"), DataType(MySqlDbType.Blob)> Public Property wl_notificationtimestamp As Byte()
#End Region
#Region "Public SQL Interface"
#Region "Interface SQL"
    Private Shared ReadOnly INSERT_SQL As String = <SQL>INSERT INTO `lib_wikiwatchlist` (`wl_user`, `wl_namespace`, `wl_title`, `wl_notificationtimestamp`) VALUES ('{0}', '{1}', '{2}', '{3}');</SQL>
    Private Shared ReadOnly REPLACE_SQL As String = <SQL>REPLACE INTO `lib_wikiwatchlist` (`wl_user`, `wl_namespace`, `wl_title`, `wl_notificationtimestamp`) VALUES ('{0}', '{1}', '{2}', '{3}');</SQL>
    Private Shared ReadOnly DELETE_SQL As String = <SQL>DELETE FROM `lib_wikiwatchlist` WHERE `wl_user`='{0}' and `wl_namespace`='{1}' and `wl_title`='{2}';</SQL>
    Private Shared ReadOnly UPDATE_SQL As String = <SQL>UPDATE `lib_wikiwatchlist` SET `wl_user`='{0}', `wl_namespace`='{1}', `wl_title`='{2}', `wl_notificationtimestamp`='{3}' WHERE `wl_user`='{4}' and `wl_namespace`='{5}' and `wl_title`='{6}';</SQL>
#End Region
    Public Overrides Function GetDeleteSQL() As String
        Return String.Format(DELETE_SQL, wl_user, wl_namespace, wl_title)
    End Function
    Public Overrides Function GetInsertSQL() As String
        Return String.Format(INSERT_SQL, wl_user, wl_namespace, wl_title, wl_notificationtimestamp)
    End Function
    Public Overrides Function GetReplaceSQL() As String
        Return String.Format(REPLACE_SQL, wl_user, wl_namespace, wl_title, wl_notificationtimestamp)
    End Function
    Public Overrides Function GetUpdateSQL() As String
        Return String.Format(UPDATE_SQL, wl_user, wl_namespace, wl_title, wl_notificationtimestamp, wl_user, wl_namespace, wl_title)
    End Function
#End Region
End Class


End Namespace
