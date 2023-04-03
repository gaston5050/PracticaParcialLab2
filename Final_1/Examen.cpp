#include "Examen.h"

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