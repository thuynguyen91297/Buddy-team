create database BuddyTeam
create table AccountUser(ID varchar (5), email varchar (100), password varchar (100)
					constraint pk_User primary key (ID)) 
create table Board ( IDBoard  varchar (5), Title nvarchar (100), constraint pk_Board primary key ( IDBoard))
create table BoardMember(IDTeam varchar (5), IDUser varchar (5), IDBoard varchar (5)
					constraint pkBoardMem primary key (IDTeam),
					constraint fkToUser foreign key (IDUser) references AccountUser(ID),
					constraint fkToBoad foreign key (IDBoard ) references Board (IDBoard ))
drop table BoardMember
create table List(IDList varchar (5),Title nvarchar(100),IDBoard varchar (5), Descriptions nvarchar (500),
				constraint pk_List primary key (IDList),
				constraint fkListToBoard foreign key (IDBoard ) references Board (IDBoard ))
create table Cards(IDCard varchar (5),Title nvarchar(100),IDList varchar (5), Descriptions nvarchar (500), beginDate date, endDate date,
				constraint pk_Card primary key (IDCard ),
				constraint fkCardToList foreign key (IDList ) references List (IDList))
drop table Cards
drop table List