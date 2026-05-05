//crear una app que simule un sistema de un cajero automatico
//1-tres intentos, al tercer intento bloquear la tarjeta
//2-consultar el saldo
//3-retirar dinero
//4-deposito de dinero
//5 salir
Algoritmo Cajeroautomatico
	Definir saldo, deposito, retiro Como Real
	Definir opc, intentos Como Entero
	Definir pin, pincorrecto Como Entero
	
	saldo=10000
	pincorrecto=1234
	intentos=0
	
	//validar el acceso por medio del pin
	Mientras intentos<3 Hacer
		Escribir Sin Saltar "Ingrese su pin: "
		Leer pin
		
		Si pin == pincorrecto Entonces
			Limpiar Pantalla
			Escribir "Acceso Concebido!!!"
			Repetir
				Escribir "=============================="
				Escribir "        MENU PRINCIPAL        "
				Escribir "1- Consultar el saldo"
				Escribir "2- Depositar Dinero"
				Escribir "3- Retirar Dinero"
				Escribir "4- Salir"
				Escribir "=============================="
				
				Escribir Sin Saltar "Seleccione una opción [ ]"
				Leer opc
				
				Segun opc Hacer
					1:
						Limpiar Pantalla
						Escribir "Su saldo es: Q.", saldo
						Escribir "Presione una tecla para volver al menu"
						Esperar Tecla
					2:
						Limpiar Pantalla
						Escribir Sin Saltar "Ingrese el monto a depositar Q."
						Leer deposito
						saldo = saldo + deposito
						Escribir "Deposito exitoso, saldo nuevo: Q.", saldo 
						Escribir "Presione una tecla para volver al menu"
						Esperar Tecla
					3:
						Limpiar Pantalla
						Escribir Sin Saltar "Ingrese el monto a retirar"
						leer retiro
						Si retiro<=saldo Entonces
							saldo=saldo-retiro
							Escribir "Retiro exitoso, nuevo saldo Q.", saldo
						SiNo
							Escribir "Fondos insuficientes"
						FinSi
						Escribir "Presione una tecla para volver al menu"
						Esperar Tecla
					4:
						Limpiar Pantalla
						Escribir "Gracias por usar el cajero"
					De Otro Modo:
						Escribir "Opcion invalida"
						Escribir "Presione una tecla para volver al menu"
						Esperar Tecla
				Fin Segun
			Hasta Que opc == 4
			//terminar el programa
			intentos=3
			
		SiNo
			intentos = intentos+1
			Escribir "PIN INCORRECTO, intento: ", intentos," de 3"
			
		Fin Si
	Fin Mientras
	//bloqueo de tarjeta
	Si intentos==3 Entonces
		Escribir "Tarjeta bloqueada"
	Fin Si
	si intentod==5 Entonces
		Escribir ()
	FinSi
	
	Escribir "Presione una tecla para salir"
	Esperar Tecla
FinAlgoritmo
