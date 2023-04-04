#include <iostream>
#include "Soluciones.h"
#include "Examen.h"
#include "ExamenesFinales.h"
#include "EstudiantesArchivo.h"
void Soluciones::Punto1(){
	
	EstudiantesArchivo reg;
	

	
	ExamenesFinales aux;
	/*Examen reg2;
	std::cout<<reg2.leerArchivoExamenes(0).getLegajo()<<std::endl;
	system("pause");
	*/

	aux.cargar();
	std::cout << std::endl;
	
	aux.mostrar();


}

void Soluciones::Punto2(){}
void Soluciones::Punto3(){}
