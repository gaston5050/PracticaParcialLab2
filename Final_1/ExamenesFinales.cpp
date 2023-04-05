#include <iostream>
#include <cstring>
#include "ExamenesFinales.h"
#include "Examen.h"
#include "EstudiantesArchivo.h"


ExamenesFinales::ExamenesFinales() {
	Examen reg;
	setId(reg.cantidadExamenes());
	setLegajo(0);
	setObservaciones("");
	setFecha(0, 0, 0);
	setIdMateria(0);
	setNota(0);

}



void ExamenesFinales::cargar() {
	Examen aux;
	

	system("pause");
	std::string obs;
	std::cout << "ID: " << getId() + 1 << std::endl;

	std::cout << "INGRESE LEGAJO" << std::endl;
	std::cin >> _legajo;
	while (!exiteEsteLegajo(_legajo)) {
		std::cout << "INGRESE UN LEGAJO EXISTENTE" << std::endl;
		std::cin >> _legajo;

	}


	std::cout << "INGRESE OBSERVACIONES" << std::endl;
	std::cin.ignore();
	std::getline(std::cin, obs);
	std::cout << "obs " << obs.length() << std::endl;
	setObservaciones(obs);
	//std::cout << "vectoriono " << strlen(_observaciones) <<std::endl;
	std::cout << "INGRESE IDMATERIA" << std::endl;
	std::cin >> _idMateria;
	while (_idMateria < 1 || _idMateria >11) {
		std::cout << "INGRESE UN IDMATERIA EXISTENTE" << std::endl;
		std::cin >> _idMateria;

	}
	std::cout << "INGRSE NOTA" << std::endl;
	std::cin >> _nota;

	if (yaAprobo(_legajo, _idMateria)) {
		Examen reg;
		reg.crearExamenFinal(*this);
		std::cout << "registro grabado" << std::endl;

	}
	else {

		std::cout << "no grabo" << std::endl;
	}





}

void ExamenesFinales::mostrar() {

	std::cout << "ID: " << getId() + 1 << std::endl;
	std::cout << "LEGAJO: " << getLegajo() << std::endl;

	std::cout << "OBSERVACIONES: " << getObservaciones() << std::endl;

	std::cout << "IDMATERIA: " << getIdMateria() << std::endl;

	std::cout << "NOTA: " << getNota() << std::endl;






}




void ExamenesFinales::setId(int id) { _id = id; }
void ExamenesFinales::setLegajo(int legajo) { _legajo = legajo; }
void ExamenesFinales::setObservaciones(std::string observaciones) {
	strcpy(_observaciones, observaciones.c_str());
}
void ExamenesFinales::setFecha(int d, int m, int a) {
	_fecha.setDia(d);
	_fecha.setMes(m);
	_fecha.setAnio(a);
}
void ExamenesFinales::setIdMateria(int idMateria) { _idMateria = idMateria; }
void ExamenesFinales::setNota(float nota) {}

int ExamenesFinales::getId() { return _id; }
int ExamenesFinales::getLegajo() { return _legajo; }
std::string ExamenesFinales::getObservaciones() {

	std::string obs(_observaciones);
	return obs;
}
Fecha ExamenesFinales::getFecha() { return _fecha; }
int ExamenesFinales::getIdMateria() { return _idMateria; }
float ExamenesFinales::getNota() { return _nota; }

bool exiteEsteLegajo(int legajo) {

	EstudiantesArchivo reg;
	int cantidad = reg.getCantidad();

	for (int i = 0; i < cantidad; i++) {

		if (reg.leer(i).getLegajo() == legajo) { return true; }


	}
	return false;
}

bool yaAprobo(int legajo, int materia) {
	Examen reg;
	int cantidad = reg.cantidadExamenes();
	if (cantidad > 0) {

		for (int i = 0; i < cantidad; i++) {
			if (reg.leerArchivoExamenes(i).getLegajo() == legajo && reg.leerArchivoExamenes(i).getIdMateria() == materia && reg.leerArchivoExamenes(i).getNota()>=6) {
				std::cout << "ya aprobo" << std::endl;

				return false;

			}


		}
			return true;
	}
	else {

		return true;
	}

}