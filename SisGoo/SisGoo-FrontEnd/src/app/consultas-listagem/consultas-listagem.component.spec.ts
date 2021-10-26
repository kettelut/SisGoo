import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ConsultasListagemComponent } from './consultas-listagem.component';

describe('ConsultasListagemComponent', () => {
  let component: ConsultasListagemComponent;
  let fixture: ComponentFixture<ConsultasListagemComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ConsultasListagemComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ConsultasListagemComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
