CREATE DATABASE Student_database_Management
GO
Use Student_database_Management
GO

DROP DATABASE Student_database_Management

CREATE TABLE Student (id int primary key identity(1, 1),
						sname VARCHAR(50) NULL,
							sadd  VARCHAR(50) NULL,
								phone INT NULL,
									sem INT NULL,
										branch VARCHAR(50) NULL)
