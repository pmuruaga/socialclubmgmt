import { TipoSocio } from './tiposocio.models';


export interface Socio {
  id: number;
  nombre: string;
  apellido: string;
  telefono: string;
  fechaNacimiento: string;
  isActivo: boolean;
  telefonoUrgencias: string;
  urlFotoPerfil: any;
  tipoSocioId: number;
  dni: string;
  tipoSocio: TipoSocio;
}

export class Socio {
    id: number;
    nombre: string;
    apellido: string;
    telefono: string;
    fechaNacimiento: string;
    isActivo: boolean;
    telefonoUrgencias: string;
    urlFotoPerfil: any;
    tipoSocioId: number;
    dni: string;
    tipoSocio: TipoSocio;

  constructor(datos?: Socio) {
    if (datos != null) {
        this.id = datos.id;
        this.nombre = datos.nombre;
        this.apellido = datos.apellido;
        this.telefono = datos.telefono;
        this.fechaNacimiento = datos.fechaNacimiento;
        this.isActivo = datos.isActivo;
        this.telefonoUrgencias = datos.telefonoUrgencias;
        this.urlFotoPerfil = datos.urlFotoPerfil;
        this.tipoSocioId = datos.tipoSocioId;
        this.dni = datos.dni;
        this.tipoSocio = datos.tipoSocio;
        return;
    }
    this.id = datos.id;
    this.nombre = datos.nombre;
    this.apellido = datos.apellido;
    this.telefono = datos.telefono;
    this.fechaNacimiento = datos.fechaNacimiento;
    this.isActivo = datos.isActivo;
    this.telefonoUrgencias = datos.telefonoUrgencias;
    this.urlFotoPerfil = datos.urlFotoPerfil;
    this.tipoSocioId = datos.tipoSocioId;
    this.dni = datos.dni;
    this.tipoSocio = datos.tipoSocio;
  }
}
