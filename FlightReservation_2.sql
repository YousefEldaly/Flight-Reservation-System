/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2017                    */
/* Created on:     5/18/2023 3:11:26 PM                         */
/*==============================================================*/
if exists (select 1
            from  sysobjects
           where  id = object_id('ADMIN')
            and   type = 'U')
   drop table ADMIN
go

if exists (select 1
            from  sysobjects
           where  id = object_id('AIRCRAFT')
            and   type = 'U')
   drop table AIRCRAFT
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('AIRCRAFTMANAGER')
            and   name  = 'RELATIONSHIP_13_FK'
            and   indid > 0
            and   indid < 255)
   drop index AIRCRAFTMANAGER.RELATIONSHIP_13_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('AIRCRAFTMANAGER')
            and   name  = 'RELATIONSHIP_12_FK'
            and   indid > 0
            and   indid < 255)
   drop index AIRCRAFTMANAGER.RELATIONSHIP_12_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('AIRCRAFTMANAGER')
            and   type = 'U')
   drop table AIRCRAFTMANAGER
go

if exists (select 1
            from  sysobjects
           where  id = object_id('CUSTOMER')
            and   type = 'U')
   drop table CUSTOMER
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('FLIGHT')
            and   name  = 'ASSIGNS_FK'
            and   indid > 0
            and   indid < 255)
   drop index FLIGHT.ASSIGNS_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('FLIGHT')
            and   type = 'U')
   drop table FLIGHT
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('FLIGHTLEG')
            and   name  = 'HAS_FK'
            and   indid > 0
            and   indid < 255)
   drop index FLIGHTLEG.HAS_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('FLIGHTLEG')
            and   type = 'U')
   drop table FLIGHTLEG
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('FLIGHTMANAGER')
            and   name  = 'RELATIONSHIP_9_FK'
            and   indid > 0
            and   indid < 255)
   drop index FLIGHTMANAGER.RELATIONSHIP_9_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('FLIGHTMANAGER')
            and   name  = 'RELATIONSHIP_8_FK'
            and   indid > 0
            and   indid < 255)
   drop index FLIGHTMANAGER.RELATIONSHIP_8_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('FLIGHTMANAGER')
            and   type = 'U')
   drop table FLIGHTMANAGER
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('TICKET')
            and   name  = 'RESERVES_FK'
            and   indid > 0
            and   indid < 255)
   drop index TICKET.RESERVES_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('TICKET')
            and   name  = 'BOOKS_FK'
            and   indid > 0
            and   indid < 255)
   drop index TICKET.BOOKS_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TICKET')
            and   type = 'U')
   drop table TICKET
go

/*==============================================================*/
/* Table: ADMIN                                                 */
/*==============================================================*/
create table ADMIN (
   ADMINID              int  IDENTITY(1,1)          not null,
   NAME                 varchar(30)          not null,
   EMAIL                varchar(100)         not null,
   PASSWORD             varchar(18)          not null,
   PHONENUMBER          varchar(16)          not null,
   constraint PK_ADMIN primary key (ADMINID)
)
go

/*==============================================================*/
/* Table: AIRCRAFT                                              */
/*==============================================================*/
create table AIRCRAFT (
   AIRCRAFTID           int  IDENTITY(1,1)          not null,
   MODEL                varchar(20)          unique not null,
   FIRSTCSEATS          int                             null,
   ECONOMYCSEATS        int                             null,
   BUSINESSCSEATS       int                             null,
   constraint PK_AIRCRAFT primary key (AIRCRAFTID)
)
go

/*==============================================================*/
/* Table: AIRCRAFTMANAGER                                       */
/*==============================================================*/
create table AIRCRAFTMANAGER (
   AIRCRAFTID           int           not null,
   ADMINID              int           not null,
   FOREIGN KEY (AIRCRAFTID) REFERENCES AIRCRAFT(AIRCRAFTID),
   FOREIGN KEY (ADMINID) REFERENCES [ADMIN](ADMINID)
)
go


/*==============================================================*/
/* Table: CUSTOMER                                              */
/*==============================================================*/
create table CUSTOMER (
   CUSTOMERID           int  IDENTITY(1,1)   not null,
   NAME                 varchar(30)          not null,
   AGE                  int                  not null,
   GENDER               varchar(6)           not null,
   DOB                  date                 not null,
   PASSWORD             varchar(18)          not null,
   EMAIL                varchar(100)         not null,
   PHONENUMBER          varchar(16)          not null,
   constraint PK_CUSTOMER primary key (CUSTOMERID)

)
go

/*==============================================================*/
/* Table: FLIGHT                                                */
/*==============================================================*/
create table FLIGHT (
   FLIGHTID             int  IDENTITY(1,1)  not null,
   AIRCRAFTID           int                  not null,
   SOURCE               varchar(85)          not null,
   DESTINATION          varchar(85)          not null,
   DEPDATE_TIME         datetime             not null,
   ARRIVALDATE_TIME     datetime             not null,
   DURATION             int                  not null,
   BUSINESSCPRICE       int                  not null,
   FIRSTCPRICE          int                  not null,
   ECONOMYCPRICE        int                  not null,
   constraint PK_FLIGHT primary key (FLIGHTID),
   FOREIGN KEY (AIRCRAFTID) REFERENCES AIRCRAFT(AIRCRAFTID)
   ON DELETE CASCADE
   ON UPDATE CASCADE
)
go


/*==============================================================*/
/* Table: FLIGHTLEG                                             */
/*==============================================================*/
create table FLIGHTLEG (
   FLIGHTID             int                  not null,
   DEPDATE_TIME         datetime             not null,
   ARRIVALDATE_TIME     datetime             not null,
   COUNTRY              varchar(56)          not null,
   AIRPORT              varchar(75)          not null,
   DURATION             int                  not null
   FOREIGN KEY (FLIGHTID) REFERENCES FLIGHT(FLIGHTID)
   ON DELETE CASCADE
)
go

/*==============================================================*/
/* Table: FLIGHTMANAGER                                         */
/*==============================================================*/
create table FLIGHTMANAGER (
   FLIGHTID             int                  not null,
   ADMINID              int                  not null,
   FOREIGN KEY (FLIGHTID) REFERENCES FLIGHT(FLIGHTID) ON DELETE CASCADE,
   FOREIGN KEY (ADMINID) REFERENCES [ADMIN](ADMINID)
)
go

/*==============================================================*/
/* Table: TICKET                                                */
/*==============================================================*/
create table TICKET (
   TICKETID             int  IDENTITY(1,1)   not null,
   CUSTOMERID           int                  not null,
   FLIGHTID             int                  not null,
   CLASSTYPE            varchar(8)           not null,
   TOTALPRICE           int                  not null,
   SEATNUM              int                  not null,
   constraint PK_TICKET primary key (TICKETID),
   FOREIGN KEY (CUSTOMERID) REFERENCES CUSTOMER(CUSTOMERID),
   FOREIGN KEY (FLIGHTID) REFERENCES FLIGHT(FLIGHTID)
)
go

