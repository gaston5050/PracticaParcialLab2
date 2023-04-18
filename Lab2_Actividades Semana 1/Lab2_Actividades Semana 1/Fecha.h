#pragma once
#include <string>
class Fecha
{
private:
	int _dia, _mes, _anio;

public:
	Fecha();
	Fecha(int dia, int mes, int anio);

	void setDia(int dia);
	void setMes(int mes);
	void setAnio(int anio);
	
	int getDia();
	int getMes();
	int getAnio();

	std::string toString(std::string formato = "dma");


};

