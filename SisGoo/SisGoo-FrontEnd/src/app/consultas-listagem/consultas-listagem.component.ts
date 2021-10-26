import { Component, OnInit } from '@angular/core';
import { ConsultaService } from '../consulta.service';

@Component({
  selector: 'app-consultas-listagem',
  templateUrl: './consultas-listagem.component.html',
  styleUrls: ['./consultas-listagem.component.css']
})
export class ConsultasListagemComponent implements OnInit {

  consultas!: Array<any>;

  constructor(private consultaService: ConsultaService) { }

  ngOnInit(): void {
    this.listar();
  }

  listar()
  {
    this.consultaService.listar().subscribe(dados => this.consultas = dados);
  }
}
