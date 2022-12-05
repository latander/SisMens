using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisMens
{
    internal class ScripSQL
    {

        /*
         * 
         * 
create database sismens;

drop table if exists socio;
drop table if exists lancamento;




create table "socio" (
"id" serial not null,
"nome" varchar not null,
"cpf" varchar not null,
"email" varchar,
"endereco" varchar,
"telefone" varchar,
"dtnasc" date,
"genero" integer not null,
"valor_mensalidade" numeric not null,
primary key (id)
);

create table "lancamento" (
"id" serial not null,
"tipo" integer not null,
"idsocio" serial,
"valor" numeric not null,
"descricao" varchar,
"pago" boolean,
"dtpagto" date,
primary key (id),
constraint "fk_socio" foreign key (idsocio) references socio(id)
         * 
         * 
         * 
         */
    }
}
