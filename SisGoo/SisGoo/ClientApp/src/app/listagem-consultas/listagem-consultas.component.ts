import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-listagem-consultas',
  templateUrl: './listagem-consultas.component.html'
})
export class ListagemConsultasComponent {
  public consultas: Consulta[];
  public urlBase: string;
  public clientHttp: HttpClient;

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    this.urlBase = baseUrl;
    this.clientHttp = http;
  }

  listarConsultas(texto: string) {

    this.clientHttp.get<Consulta[]>(this.urlBase + 'api/Consulta/' + texto).subscribe(result => {
      this.consultas = result;
    }, error => console.error(error));

  }

}

interface Consulta {
  id: number;
  titulo: string;
  link: string;
}
