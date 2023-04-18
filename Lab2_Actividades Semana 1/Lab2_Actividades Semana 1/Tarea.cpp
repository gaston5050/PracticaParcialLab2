#include "Tarea.h"
#include <string>


void Tarea::setIdTarea(int idTarea) { idTarea = idTarea; }

void Tarea::setDescripcionTarea(std::string descripcion) {
	strcpy(	_descripcionTarea, descripcion.c_str());



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
