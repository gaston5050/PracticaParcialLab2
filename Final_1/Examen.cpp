#include "Examen.h"

bool Examen::crearExamenFinal(ExamenesFinales reg){


	FILE* p = fopen("finales.dat", "ab");
	if (p == nullptr) exit(1552);
	bool grabo = fwrite(&reg, sizeof(ExamenesFinales), 1, p);

	fclose(p);
	return grabo;
	

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