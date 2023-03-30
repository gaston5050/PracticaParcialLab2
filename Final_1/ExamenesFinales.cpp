#include <iostream>
#include "ExamenesFinales.h"
#include "Examen.h"

ExamenesFinales::ExamenesFinales(){
	Examen reg;
	setId(reg.cantidadExamenes());
	setLegajo(0);
	setObservaciones("");
	setFecha(0,0,0);
	setIdMateria(0);
	setNota(0);
	
}

void ExamenesFinales::cargar(){
	std::cout <<"ID: "<< getId()<<std::endl;
	std::cout << "INGRESE LEGAJO" <<std::endl;
	std::cin >> _legajo;
	std::cout << "INGRESE OBSERVACIONES"<< std::endl;
	std::cin >> _observaciones;
	std::cout << "INGRESE LEGAJO" <<std::endl;
	std::cin >> _legajo;
	


}

void ExamenesFinales::setId(int id) { _id = id; }
void ExamenesFinales::setLegajo(int legajo) { _legajo = legajo; }
void ExamenesFinales::setObservaciones(std::string observaciones) {
	strcpy(_observaciones, observaciones.c_str());
}
void ExamenesFinales::setFecha(int d,int m, int a){
	_fecha.setDia(d);
	_fecha.setMes(m);
	_fecha.setAnio(a);
}
void ExamenesFinales::setIdMateria(int idMateria) { _idMateria = idMateria; }
void ExamenesFinales::setNota(float nota){}

int ExamenesFinales::getId() { return _id; }
int ExamenesFinales::getLegajo() { return _legajo; }
std::string ExamenesFinales::getObservaciones() { return _observaciones; }
Fecha ExamenesFinales::getFecha() { return _fecha; }
int ExamenesFinales::getIdMateria() { return _idMateria; }
float ExamenesFinales::getNota() { return _nota; }