USE master;
GO


DROP DATABASE IF EXISTS ProjectOrganizer

CREATE DATABASE ProjectOrganizer
GO


USE ProjectOrganizer
GO


BEGIN TRANSACTION;

CREATE TABLE employee
(
	employeeId		int identity(1,1) not null,
	departmentId	int not null,
	projectId		int not null,
	firstName		varchar(20) not null,
	lastName		varchar(20) not null,
	gender			char(20),
	dateOfBirth		date not null,
	dateOfHire		date not null,

	constraint pk_employeeId primary key(employeeId),

);

	Alter table employee add constraint gender_check check ((gender = 'Male') or (gender = 'Female') or (gender = 'Other'));
	Alter table employee add constraint hireDate_check check (dateOfBirth < dateOfHire);

CREATE TABLE department
(
	departmentId	int identity(1,1) not null,
	departmentName	varchar(64) not null,

	constraint pk_departmentId primary key(departmentId)
);

CREATE TABLE project
(
	projectId		int identity(1,1) not null,
	projectName		varchar(64) not null,
	startDate		date not null,

	constraint pk_projectsId primary key(projectId),
	
);

ALTER TABLE employee ADD constraint fk_departmentId foreign key(departmentId) references department(departmentId);
ALTER TABLE employee ADD constraint fk_projectId foreign key(projectId) references project(projectId);

insert into department (departmentName) 
values ('Pro Wrestler'), ('Referee'), ('Annoucer'), ('Manager');

insert into project(projectName, startDate) 
values ('WrestleMania', '1985-03-31'), ('WrestleMania 5', '1989-04-2'), ('WrestleMania 20', '2004-03-14'), ('WrestleMania 30', '2014-04-6');

insert into employee(departmentId,projectId,firstName,lastName,gender,dateOfBirth,dateOfHire) values (1,1,'Hulk','Hogan','Male','1953-08-11','1983-08-01');
insert into employee(departmentId,projectId,firstName,lastName,gender,dateOfBirth,dateOfHire) values (1,3,'Shawn','Michaels','Male','1965-07-22','1984-10-10');
insert into employee(departmentId,projectId,firstName,lastName,gender,dateOfBirth,dateOfHire) values (2,1,'Pat','Patterson','Male','1941-01-19','1979-01-01');
insert into employee(departmentId,projectId,firstName,lastName,gender,dateOfBirth,dateOfHire) values (2,4,'Charles','Robinson','Male','1964-07-2','2001-08-02');
insert into employee(departmentId,projectId,firstName,lastName,gender,dateOfBirth,dateOfHire) values (4,2,'Miss','Elizabeth','Female','1960-11-19','1985-08-30');
insert into employee(departmentId,projectId,firstName,lastName,gender,dateOfBirth,dateOfHire) values (1,4,'Daniel','Bryan','Male','1981-05-22','2010-01-04');
insert into employee(departmentId,projectId,firstName,lastName,gender,dateOfBirth,dateOfHire) values (3,3,'Jim','Ross','Male','1952-01-03','1996-06-01');
insert into employee(departmentId,projectId,firstName,lastName,gender,dateOfBirth,dateOfHire) values (3,4,'Renee','Young','Female','1985-09-19','2013-03-29');
insert into employee(departmentId,projectId,firstName,lastName,gender,dateOfBirth,dateOfHire) values (4,4,'Vicky','Guerrero','Female','1968-04-16','2005-08-14');

commit;
