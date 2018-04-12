USE master;
GO

IF DB_ID(N'AlumnosDB') IS NULL
CREATE DATABASE AlumnosDB
ON PRIMARY
  ( NAME='AlumnosDB_Primary',
    FILENAME=
       'c:\SQLServer DB\Alumno Pair Programming\Primary\AlumnosDB_Prm.mdf',
    SIZE=4MB,
    MAXSIZE=10MB,
    FILEGROWTH=1MB),
FILEGROUP AlumnosDB_FG1
  ( NAME = 'AlumnosDB_FG1_Dat1',
    FILENAME =
       'c:\SQLServer DB\Alumno Pair Programming\Secondary\AlumnosDB_FG1_1.ndf',
    SIZE = 1MB,
    MAXSIZE=10MB,
    FILEGROWTH=1MB),
  ( NAME = 'AlumnosDB_FG1_Dat2',
    FILENAME =
       'c:\SQLServer DB\Alumno Pair Programming\Secondary\AlumnosDB_FG1_2.ndf',
    SIZE = 1MB,
    MAXSIZE=10MB,
    FILEGROWTH=1MB)
LOG ON
  ( NAME='AlumnosDB_log',
    FILENAME =
       'c:\SQLServer DB\Alumno Pair Programming\Logs\AlumnosDBLogs.ldf',
    SIZE=1MB,
    MAXSIZE=10MB,
    FILEGROWTH=1MB);
GO