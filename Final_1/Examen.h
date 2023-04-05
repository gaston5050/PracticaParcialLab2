#pragma once
#include "ExamenesFinales.h"
class Examen
{
public:
	bool crearExamenFinal(ExamenesFinales reg);
	int cantidadExamenes();
	ExamenesFinales leerArchivoExamenes(int pos);
	std::string alumnosAprobados();



};





