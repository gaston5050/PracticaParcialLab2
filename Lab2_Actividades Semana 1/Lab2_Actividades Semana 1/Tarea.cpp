#include <iostream>
#include "Tarea.h"
#include <string>


Tarea::Tarea(){



	_idTarea = -1;
	setDescripcionTarea("no");
	setDificultad("fac");

	 _estado = 0;
}
void Tarea::setIdTarea(int idTarea) { idTarea = idTarea; }

void Tarea::setDescripcionTarea(std::string descripcion) {
	strcpy(_descripcionTarea, descripcion.c_str());



}
void Tarea::setDificultad(std::string dificultad) { strcpy(_dificultad, dificultad.c_str()); }
void Tarea::setEstado(bool estado) { _estado = estado; }

int Tarea::getIdTarea() { return _idTarea; }
std::string Tarea::getDescripcionTarea() {
	std::string descri = _descripcionTarea;

	return descri;

}
std::string Tarea::getDificultad() {
	std::string dificultad(_dificultad);
	return dificultad;
}
bool Tarea::getEstado() {
	return _estado;
}

void Tarea::cargar() {
	int d, m, a;
	std::string texto;
	std::cout << "INGRESE ID TAREA" << std::endl;
	std::cin >> _idTarea;
	std::cout << "INGRESE DIFICULTAD" << std::endl;
	
	std::cin.ignore();
	getline(std::cin, texto);
	setDificultad(texto);
	std::cout << "INGRESE FECHA DIA LIMITE" << std::endl;
	std::cin >> d;
	std::cout << "INGRESE FECHA MES LIMITE" << std::endl;
	std::cin >> m;
	std::cout << "INGRESE FECHA ANIO LIMITE" << std::endl;

	std::cin >> a;
	_fechaLimite.setDia(d);
	_fechaLimite.setMes(m);
	_fechaLimite.setAnio(a);

	std::cout << "INGRESE DESCRIPCION DE LA  TAREA" << std::endl;
	std::cin.ignore();
	getline(std::cin, texto);
	setDescripcionTarea(texto);

	

}

void Tarea::mostrar() {
	

	std::cout << "ID TAREA: " << _idTarea << std::endl;
	std::cout << "FECHA: " << _fechaLimite.toString() << std::endl;
	std::cout << "DESCRIPCION DE LA  TAREA: " << _descripcionTarea << std::endl;
	std::cout << "DIFICULTAD: " << _dificultad << std::endl;
}