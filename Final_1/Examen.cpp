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


	bool materias[11]{};
	int contador; 
	int cantidadAlumnos = reg.getCantidad();

	for (int i = 0; i < cantidadAlumnos; i++) {
		contador = 0;
			
		int legajoTestigo = reg.leer(i).getLegajo();
	
		
		for (int j = 0; j < cantidadExa; j++) {
			{

				if (aux.leerArchivoExamenes(j).getLegajo() == legajoTestigo && aux.leerArchivoExamenes(i).getNota()>=6) {

					materias[aux.leerArchivoExamenes(j).getIdMateria() - 1] = true;
				}

			}

		}
		for (int j = 0; j < 11; j++) {
			std::cout << "LEGAJO: " << 
			if (materias[j] == true){
				contador++;

			}
		}

		if (contador == 3) {
			std::cout << reg.leer(i).toString() << std::endl;
		}
	}

}