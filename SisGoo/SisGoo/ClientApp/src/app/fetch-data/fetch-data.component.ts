import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-fetch-data',
  templateUrl: './fetch-data.component.html'
})
export class FetchDataComponent {
  public consultas: Consulta[];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<Consulta[]>(baseUrl + 'api/Consulta/x').subscribe(result => {
      this.consultas = result;
    }, error => console.error(error));
  }
}

interface Consulta {
  id: number;
  titulo: string;
  link: string;
}
