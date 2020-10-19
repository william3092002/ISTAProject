-- Name: William Chan
-- File: project database
-- Date: 8/8/2020

drop table if exists teamMembers;
go
create table dbo.teamMembers(
	memberID int,
	teamLeadID int,
	memberName varchar(100),
	member_e_mail varchar (100),
	memberPhone nvarchar(100),
	CONSTRAINT teamMember_PK PRIMARY KEY(memberID) 
	);
	go
	
 BULK INSERT dbo.teamMembers FROM 'D:\quantico06\ISTA_Project\teamMember.csv'
 WITH
 (
 format = 'csv',
 firstrow = 2,
 DATAFILETYPE = 'char' ,
 FIELDTERMINATOR = ',',
 ROWTERMINATOR = '\n'
 );
go

	select * from teamMembers

drop table if exists teamLeaders;
go
create table dbo.teamLeaders(
	teamLeadID int, 
	leaderName varchar (100),
	leader_e_mail varchar (100),
	leaderPhone varchar(50),
	title varchar(50),
	CONSTRAINT teamLeader_PK PRIMARY KEY(teamLeadID) 
	);
	go

	BULK INSERT dbo.teamLeaders FROM 'D:\quantico06\ISTA_Project\teamLeader.csv'
 WITH
 (
 format = 'csv',
 firstrow = 2,
 DATAFILETYPE = 'char' ,
 FIELDTERMINATOR = ',',
 ROWTERMINATOR = '\n'
 );
go

	select * from teamLeaders

drop table if exists projects;
go
create table dbo.projects(
	projectID VARCHAR(10), 
	projectName varchar(100),
	projectDescription varchar (MAX),
	projectBegin date,
	projectDueDate date,	
	projectStatus varchar(50),
	projectComplete date,
	tLeaderID int,
	CONSTRAINT project_PK PRIMARY KEY(projectID) 
	);
	go

	BULK INSERT dbo.projects FROM 'D:\quantico06\ISTA_Project\projects.csv'
 WITH
 (
 format = 'csv',
 firstrow = 2,
 DATAFILETYPE = 'char' ,
 FIELDTERMINATOR = ',',
 ROWTERMINATOR = '\n'
 );
go

	select * from projects

	

drop table if exists tasks;
go

	create table dbo.tasks(
	taskID varchar(10), 
	taskName varchar(100),
	tDescription varchar(Max),
	tStatus varchar(50),
	tRequired int,
	tBegin date,
	tDue date,
	tcomplete date,
	projectID varchar(10),
	phaseName varchar(50),
	memberID int,
	CONSTRAINT task_PK PRIMARY KEY(taskID) 
	);
	go

	BULK INSERT dbo.tasks FROM 'D:\quantico06\ISTA_Project\tasks.csv'
 WITH
 (
 format = 'csv',
 firstrow = 2,
 DATAFILETYPE = 'char' ,
 FIELDTERMINATOR = ',',
 ROWTERMINATOR = '\n'
 );
go

select * from tasks

select t.tstatus, m.membername, t.tDue 
from tasks t 
inner join teammembers m on t.memberID = m.memberID
where t.tStatus like 'assigned'
order by t.tDue desc