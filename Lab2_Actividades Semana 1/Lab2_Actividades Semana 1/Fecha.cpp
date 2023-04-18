#include "Fecha.h"
#include <string>
#include <ctime>


Fecha::Fecha() {
	time_t now = time(0);
//	char* dt = ctime(&now);
	tm* ltm = localtime(&now);

	setAnio(1900 + ltm->tm_year);
	setMes(1 + ltm->tm_mon);
	setDia(ltm->tm_mday);


}
Fecha::Fecha(int dia, int mes, int anio) {

	if (dia <= 0 || mes <= 0 || anio <= 0) {


		Fecha aux;
		dia = aux.getDia();
		mes = aux.getMes();
		anio = aux.getAnio();
	}





}

void Fecha::setDia(int dia) { _dia = dia; }
void Fecha::setMes(int mes) { _mes = mes; }
void Fecha::setAnio(int anio) { _anio = anio; }

int Fecha::getDia() { return _dia; }
int Fecha::getMes() { return _mes; }
int Fecha::getAnio() { return _anio; }

std::string Fecha::toString(std::string formato) {

	std::string fecha;

	std::string dia = std::to_string(_dia);
	if (_dia < 10) { dia = "0" + dia ; }
	std::string mes = std::to_string(_mes);
	if (_mes < 10) mes = "0" + mes;
	std::string anio = std::to_string(_anio);
	if(formato != "dma")

	fecha =   anio +"/"+ mes +"/" + dia;
	else 
	fecha = dia +"/"+ mes+"/" + anio;


return fecha;

	}