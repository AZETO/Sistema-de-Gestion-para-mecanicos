/*==============================================================*/
/* DBMS name:      MySQL 5.0                                    */
/* Created on:     04-05-2022 2:51:29                           */
/*==============================================================*/


drop table if exists CATALOGOS;

drop table if exists CATALOGOTALLERES;

drop table if exists CLIENTE;

drop table if exists FORMULARIOV;

drop table if exists INTERFACE;

drop table if exists LOGIN;

drop table if exists MECANICO;

drop table if exists MODULOBOUCHER;

drop table if exists MODULOVALORACION;

drop table if exists PRODUCTO;

drop table if exists REGISTRAR;

drop table if exists SERVICIO;

/*==============================================================*/
/* Table: CATALOGOS                                             */
/*==============================================================*/
create table CATALOGOS
(
   IDSERVICIO           char(10),
   NOMTALLER            char(10),
   COMECANICO           char(10),
   CATALOGOPRODUCTO     char(10),
   CATALOGOSERVICIO     char(10)
);

/*==============================================================*/
/* Table: CATALOGOTALLERES                                      */
/*==============================================================*/
create table CATALOGOTALLERES
(
   NOMMECA              char(10),
   NOMTALLER            char(10) not null,
   COMECANICO           char(10) not null,
   RUTCLI               char(10),
   DUENO                char(10),
   CORREOCLI            char(10),
   TALLER               char(10),
   USUMECA              char(10),
   DIRECMECANICO        char(10),
   TIPPRODUCTO          char(10),
   TIPSERVICIO          char(10),
   primary key (NOMTALLER, COMECANICO)
);

/*==============================================================*/
/* Table: CLIENTE                                               */
/*==============================================================*/
create table CLIENTE
(
   NOMCLIENTE           char(10),
   USUCLIENTE           char(10) not null,
   COCLIENTE            char(10) not null,
   RTCLIENTE            char(10),
   PASSWORD             char(10),
   TELECLIENTE          char(10),
   primary key (USUCLIENTE, COCLIENTE)
);

/*==============================================================*/
/* Table: FORMULARIOV                                           */
/*==============================================================*/
create table FORMULARIOV
(
   MARCA                char(10),
   MODELO               char(10),
   ANO                  char(10),
   RUTCLI               char(10) not null,
   TELEFONOCLI          char(10),
   DUENO                char(10) not null,
   CORREOCLI            char(10) not null,
   USUCLIENTE           char(10),
   COCLIENTE            char(10),
   primary key (RUTCLI, DUENO, CORREOCLI)
);

/*==============================================================*/
/* Table: INTERFACE                                             */
/*==============================================================*/
create table INTERFACE
(
   PORTADA              char(10),
   LOGIN                char(10),
   REGISTRAR            char(10)
);

/*==============================================================*/
/* Table: LOGIN                                                 */
/*==============================================================*/
create table LOGIN
(
   USUARIOCLI           char(10) not null,
   USUARIOMEC           char(10) not null,
   PASS                 char(10),
   primary key (USUARIOCLI, USUARIOMEC)
);

/*==============================================================*/
/* Table: MECANICO                                              */
/*==============================================================*/
create table MECANICO
(
   NOMBREM              char(10),
   TALLER               char(10) not null,
   USUMECA              char(10) not null,
   NOMBRETALLER         char(10),
   NOMTALLER            char(10),
   COMECANICO           char(10),
   DIRECMECA            char(10),
   PRODUCTOS            char(10),
   SERVICIOS            char(10),
   COMECA               char(10),
   TELEMECA             char(10),
   primary key (TALLER, USUMECA)
);

/*==============================================================*/
/* Table: MODULOBOUCHER                                         */
/*==============================================================*/
create table MODULOBOUCHER
(
   NOMBRECLIENTE        char(10),
   CORREOCLIENTE        char(10) not null,
   RUTCLIENTE           char(10) not null,
   NONBREMECA           char(10),
   TALLERMECANICO       char(10) not null,
   DIRECCIONTALLER      char(10),
   CORREOMECANICO       char(10) not null,
   IDSERVICIO           char(10),
   IDPRODUCTO           char(10),
   NOMBRETALLER         char(10),
   PRECIO               char(10),
   FECHA                char(10),
   primary key (CORREOCLIENTE, RUTCLIENTE, TALLERMECANICO, CORREOMECANICO)
);

/*==============================================================*/
/* Table: MODULOVALORACION                                      */
/*==============================================================*/
create table MODULOVALORACION
(
   NOMBRETALLER         char(10) not null,
   CORREOCLIENTE        char(10),
   RUTCLIENTE           char(10),
   TALLERMECANICO       char(10),
   CORREOMECANICO       char(10),
   TALLER               char(10),
   USUMECA              char(10),
   TIPOSERVICIO         char(10),
   COMENTARIO           char(10),
   NOTA                 char(10),
   primary key (NOMBRETALLER)
);

/*==============================================================*/
/* Table: PRODUCTO                                              */
/*==============================================================*/
create table PRODUCTO
(
   PRODUCTOTALLER       char(10),
   IDPRODUCTO           char(10) not null,
   CORREOCLIENTE        char(10),
   RUTCLIENTE           char(10),
   TALLERMECANICO       char(10),
   CORREOMECANICO       char(10),
   primary key (IDPRODUCTO)
);

/*==============================================================*/
/* Table: REGISTRAR                                             */
/*==============================================================*/
create table REGISTRAR
(
   USUCLIENTE           char(10),
   COCLIENTE            char(10),
   USUARIOCLI           char(10),
   USUARIOMEC           char(10),
   NUEVOUSUARIO         char(10),
   NUEVACONTRASENA      char(10)
);

/*==============================================================*/
/* Table: SERVICIO                                              */
/*==============================================================*/
create table SERVICIO
(
   SERVICIOTALLER       char(10),
   IDSERVICIO           char(10) not null,
   CORREOCLIENTE        char(10),
   RUTCLIENTE           char(10),
   TALLERMECANICO       char(10),
   CORREOMECANICO       char(10),
   primary key (IDSERVICIO)
);

alter table CATALOGOS add constraint FK_ESCOGER_TIPO_DE foreign key (IDSERVICIO)
      references SERVICIO (IDSERVICIO) on delete restrict on update restrict;

alter table CATALOGOS add constraint FK_SELECCIONA_TIPO_DE foreign key (NOMTALLER, COMECANICO)
      references CATALOGOTALLERES (NOMTALLER, COMECANICO) on delete restrict on update restrict;

alter table CATALOGOTALLERES add constraint FK_SELECCIONA_UN foreign key (RUTCLI, DUENO, CORREOCLI)
      references FORMULARIOV (RUTCLI, DUENO, CORREOCLI) on delete restrict on update restrict;

alter table CATALOGOTALLERES add constraint FK_SE_REGISTRA2 foreign key (TALLER, USUMECA)
      references MECANICO (TALLER, USUMECA) on delete restrict on update restrict;

alter table FORMULARIOV add constraint FK_OPCION_A_REALIZAR foreign key (USUCLIENTE, COCLIENTE)
      references CLIENTE (USUCLIENTE, COCLIENTE) on delete restrict on update restrict;

alter table MECANICO add constraint FK_PASA_A_VALORAR_A foreign key (NOMBRETALLER)
      references MODULOVALORACION (NOMBRETALLER) on delete restrict on update restrict;

alter table MECANICO add constraint FK_SE_REGISTRA foreign key (NOMTALLER, COMECANICO)
      references CATALOGOTALLERES (NOMTALLER, COMECANICO) on delete restrict on update restrict;

alter table MODULOBOUCHER add constraint FK_PASA_A2 foreign key (IDPRODUCTO)
      references PRODUCTO (IDPRODUCTO) on delete restrict on update restrict;

alter table MODULOBOUCHER add constraint FK_PUEDE_REALIZAR foreign key (NOMBRETALLER)
      references MODULOVALORACION (NOMBRETALLER) on delete restrict on update restrict;

alter table MODULOBOUCHER add constraint FK_SIGUENTE2 foreign key (IDSERVICIO)
      references SERVICIO (IDSERVICIO) on delete restrict on update restrict;

alter table MODULOVALORACION add constraint FK_PASA_A_VALORAR_A2 foreign key (TALLER, USUMECA)
      references MECANICO (TALLER, USUMECA) on delete restrict on update restrict;

alter table MODULOVALORACION add constraint FK_PUEDE_REALIZAR2 foreign key (CORREOCLIENTE, RUTCLIENTE, TALLERMECANICO, CORREOMECANICO)
      references MODULOBOUCHER (CORREOCLIENTE, RUTCLIENTE, TALLERMECANICO, CORREOMECANICO) on delete restrict on update restrict;

alter table PRODUCTO add constraint FK_PASA_A foreign key (CORREOCLIENTE, RUTCLIENTE, TALLERMECANICO, CORREOMECANICO)
      references MODULOBOUCHER (CORREOCLIENTE, RUTCLIENTE, TALLERMECANICO, CORREOMECANICO) on delete restrict on update restrict;

alter table REGISTRAR add constraint FK_INGRESA2 foreign key (USUCLIENTE, COCLIENTE)
      references CLIENTE (USUCLIENTE, COCLIENTE) on delete restrict on update restrict;

alter table REGISTRAR add constraint FK_PUEDE foreign key (USUARIOCLI, USUARIOMEC)
      references LOGIN (USUARIOCLI, USUARIOMEC) on delete restrict on update restrict;

alter table SERVICIO add constraint FK_SIGUENTE foreign key (CORREOCLIENTE, RUTCLIENTE, TALLERMECANICO, CORREOMECANICO)
      references MODULOBOUCHER (CORREOCLIENTE, RUTCLIENTE, TALLERMECANICO, CORREOMECANICO) on delete restrict on update restrict;

