import { Component, OnInit } from '@angular/core';
import { SociosService } from '../socios.service';
import { Socio } from '../models/socio.models';
import { Router } from '@angular/router';

@Component({
  selector: 'app-listado-socios',
  templateUrl: './listado-socios.page.html',
  styleUrls: ['./listado-socios.page.scss'],
})
export class ListadoSociosPage implements OnInit {

  socios: Socio[];
  constructor(public sociosService: SociosService, private router: Router) { }

  ngOnInit() {
    this.sociosService.listarSocios().subscribe((socios) => {
      this.socios = socios;
      console.log(socios);
    }, (error) => {
      console.log(error);
    });
  }

  irADetalleSocio(socio: Socio) {
    // this.router.navigate(['socio-detalle', {noticia: JSON.stringify(socio)}]);
    console.log('Ir a Detalle');
  }

  eliminarSocio(socioID: number, indice: number) {
    // this.noticiasService.eliminarNoticia(noticiaID).subscribe(() => {
    //   this.noticias.splice(indice, 1); // Me elimina el item en la posición indice.
    // }, error => {
    //   console.log(error);
    // });
    console.log('Eliminar Socio');
  }

  buscarSocio(dni: string) {
    // this.noticiasService.eliminarNoticia(noticiaID).subscribe(() => {
    //   this.noticias.splice(indice, 1); // Me elimina el item en la posición indice.
    // }, error => {
    //   console.log(error);
    // });
    console.log('Buscar Socio: ' + dni);

    if (dni.length > 3) {
      this.sociosService.buscarSocio(dni).subscribe((socios) => {
        this.socios = socios;
        console.log(socios);
      }, (error) => {
        console.log(error);
      });
    }
    else if (dni.length == 0) {
      this.sociosService.listarSocios().subscribe((socios) => {
        this.socios = socios;
        console.log(socios);
      }, (error) => {
        console.log(error);
      });
    }
  }

  editar(socio: Socio) {
    // this.router.navigate(['/agregar', {noticia: JSON.stringify(noticia)}]);
    console.log('Editar Socio');
  }

}
