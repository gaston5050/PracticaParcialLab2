#include <iostream>
#include "Soluciones.h"
#include "Examen.h"
#include "ExamenesFinales.h"
#include "EstudiantesArchivo.h"
void Soluciones::Punto1() {

	EstudiantesArchivo reg;








	ExamenesFinales aux;
   //	aux.cargar();

	Examen auxi;

	for (int i = 0; i <auxi.cantidadExamenes(); i++) {
		auxi.leerArchivoExamenes(i).mostrar();
		
std::cout << std::endl;


	}
	

	//}



		/*Examen reg2;
		std::cout<<reg2.leerArchivoExamenes(0).getLegajo()<<std::endl;
		system("pause");

		aux.cargar();
		std::cout << std::endl;

		aux.mostrar();


	}

	void Soluciones::Punto2(){

		Examen auxi;
	   auxi.alumnosAprobados();

	}
		*/
}
	void Soluciones::Punto3() {

		Examen x;
		x.dificultadExamen(2023);









	}