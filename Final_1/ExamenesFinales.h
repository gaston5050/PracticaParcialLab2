#pragma once
#include <string>
#include "Fecha.h"
class ExamenesFinales
{

private: 
	int _id;
	int _legajo;
	char _observaciones[50];
	Fecha _fecha;
	int _idMateria;
	float _nota;

public:
	ExamenesFinales();
	void cargar();

	void setId(int id);
	void setLegajo(int legajo);
	void setObservaciones(std::string observaciones);
	void setFecha(int d, int m, int a);
	void setIdMateria(int idMateria);
	void setNota(float nota);

	int getId();
	int getLegajo();
	std::string getObservaciones();
	Fecha getFecha();
	int getIdMateria();
	float getNota();

	void mostrar();








};

bool exiteEsteLegajo(int legajo);
