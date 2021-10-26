import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class ConsultaService {

  consultasUrl = 'https://localhost:44372/api/Consulta/x';

  constructor(private http: HttpClient) { }

  listar()
  {
     return this.http.get<any[]>(`${this.consultasUrl}`)
  }
}
