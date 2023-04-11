#include <iostream>
#include "Examen.h"
#include "EstudiantesArchivo.h"
bool Examen::crearExamenFinal(ExamenesFinales reg){


	FILE* p = fopen("finales.dat", "ab");
	if (p == nullptr) exit(1552);
	bool grabo = fwrite(&reg, sizeof(ExamenesFinales), 1, p);

	fclose(p);
	return grabo;
	

}

ExamenesFinales Examen::leerArchivoExamenes(int pos) {
	ExamenesFinales reg;

	FILE* p = fopen("finales.dat", "rb");
	if (p == nullptr) exit(1552);
	fseek(p, sizeof(ExamenesFinales) * pos, SEEK_SET);
	fread(&reg, sizeof(ExamenesFinales), 1, p);
	fclose(p);
	return reg;





}

int Examen::cantidadExamenes() {

	FILE* p = fopen("finales.dat", "rb");
	if (p == nullptr) {
		return 0;
		//exit(1552);
	}
	fseek(p, 0, SEEK_END);
	int cantidad = ftell(p)/ sizeof(ExamenesFinales);
	return cantidad;

}


void Examen::alumnosAprobados() {

	EstudiantesArchivo reg;
	Examen aux;
	int cantidadExa = cantidadExamenes();


	int contador= 0; 
	int cantidadAlumnos = reg.getCantidad();
	int j = 0;

	for (int i = 0; i < cantidadAlumnos; i++) {
	bool materias[3]{};
			
		int legajoTestigo = reg.leer(i).getLegajo();
	
		
		for (int j = 0; j < cantidadExa; j++) {
			{

				if (aux.leerArchivoExamenes(j).getLegajo() == legajoTestigo && aux.leerArchivoExamenes(i).getNota()>=6) {

					materias[aux.leerArchivoExamenes(j).getIdMateria() - 1] = true;
				}
			

			}

		}
		for (int j = 0; j < 3; j++) {
			
			if (materias[j] == true){
				contador++;
				materias[j] == false;

			}
		}

		if (contador == 3) {

			std::cout << reg.leer(i).toString() << std::endl;
		}
		contador = 0;
	}

}


void Examen::dificultadExamen(int anio) {

	int cont, aprobados, desaprobados;
	for (int i = 0; i < 3; i++) {
		cont = aprobados = desaprobados = 0;
		for (int j = 0; j < cantidadExamenes(); j++) {

			if (leerArchivoExamenes(j).getIdMateria() == i+1) {
				cont++;
				if (leerArchivoExamenes(j).getNota() >= 6) { aprobados++; }
				else { desaprobados++; }
			}

		}

			std::cout << " MATERIA: " << i+1 << std::endl;
			std::cout << "PORCENTAJE APROBADOS: " << (aprobados * 100) / (float)cont <<std::endl;
			std::cout << "PORCENTAJE DESAPROBADOS: " << (desaprobados * 100) / (float)cont << std::endl;





	}



}