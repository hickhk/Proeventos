import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-eventos',
  templateUrl: './eventos.component.html',
  styleUrls: ['./eventos.component.scss']
})
export class EventosComponent implements OnInit {

  constructor(private http: HttpClient ) { }

  public eventos: any = [];
  public eventFilters: any = [];
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

  getEventos(){
    this.http.get("https://localhost:5001/api/Eventos").subscribe(
      response =>
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


private filterEvents(filterBy: string){
  filterBy = filterBy.toLocaleLowerCase();
  return this.eventos.filter(
    (evento: { tema: string; local: string }) =>
    evento.tema.toLocaleLowerCase().indexOf(filterBy) !== -1
    || evento.local.toLocaleLowerCase().indexOf(filterBy) !== -1
    );
}

}
