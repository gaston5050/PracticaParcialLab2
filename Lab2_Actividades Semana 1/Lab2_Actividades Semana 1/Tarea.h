#pragma once
#include "Fecha.h"
class Tarea
{

private: 
	int _idTarea;
	char _descripcionTarea[50];
	char _dificultad[5];
	Fecha _fechaLimite;
	bool _estado;
public:
	Tarea();
	void cargar();
	void mostrar();
	void setIdTarea(int idTarea);
	void setDescripcionTarea(std::string descripcion);
	void setDificultad(std::string dificultad);
	void setEstado(bool estado);

	int getIdTarea();
	std::string getDescripcionTarea();
	std::string getDificultad();
	bool getEstado();



};

