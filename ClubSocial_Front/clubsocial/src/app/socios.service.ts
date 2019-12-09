import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Socio } from './models/socio.models';

@Injectable({
  providedIn: 'root'
})
export class SociosService {

  constructor(public http: HttpClient) { }

  listarSocios(): Observable<Socio[]> {
    return this.http.get<Socio[]>('http://localhost:56788/api/Socios/obtener');
  }

  buscarSocio(dni: string): Observable<Socio[]> {
    return this.http.get<Socio[]>('http://localhost:56788/api/Socios/buscar/'+dni);
  }
}
