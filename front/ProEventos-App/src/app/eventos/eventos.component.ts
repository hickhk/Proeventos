import { Component, OnInit, TemplateRef } from '@angular/core';

import { BsModalService, BsModalRef } from 'ngx-bootstrap/modal';
import { ToastrService } from 'ngx-toastr';


import { Evento } from '../models/Evento';
import { EventoService } from '../services/evento.service';

@Component({
  selector: 'app-eventos',
  templateUrl: './eventos.component.html',
  styleUrls: ['./eventos.component.scss']
})
export class EventosComponent implements OnInit {

  modalRef?: BsModalRef;


  constructor(private toastr: ToastrService, private eventoService: EventoService, private modalService: BsModalService) { }



  public eventos: Evento[] = [];
  public eventFilters: Evento[] = [];
  showImages: boolean = true;
  private _filterList: string = '';

  public get filterList(): string{
  return this._filterList;
  }

  public set filterList(value: string){
    this._filterList = value;
    this.eventFilters = this._filterList ? this.filterEvents(this._filterList) : this.eventos;
    }

  ngOnInit(): void {
    this.getEventos();
   }

   public getEventos(){
     this.eventoService.getEventos().subscribe(
       (response: Evento[]) =>
       {
         this.eventos = response;
         this.eventFilters = this.eventos;
       },
       error => console.log(error)
     );
   }

  displayImages(){
      this.showImages = !this.showImages;
  }


private filterEvents(filterBy: string): Evento[]{
  filterBy = filterBy.toLocaleLowerCase();
  return this.eventos.filter(
    (evento: { tema: string; local: string }) =>
    evento.tema.toLocaleLowerCase().indexOf(filterBy) !== -1
    || evento.local.toLocaleLowerCase().indexOf(filterBy) !== -1
    );
}

openModal(template: TemplateRef<any>): void {
  this.modalRef = this.modalService.show(template, {class: 'modal-sm'});
}

confirm(): void {
  this.modalRef?.hide();
}

decline(): void {
  this.modalRef?.hide();
}

}
