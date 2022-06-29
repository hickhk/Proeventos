import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ContatosComponent } from './Componentes/Contatos/Contatos.component';
import { DashboardComponent } from './Componentes/Dashboard/Dashboard.component';
import { EventoDetalheComponent } from './Componentes/eventos/evento-detalhe/evento-detalhe.component';
import { EventoListaComponent } from './Componentes/eventos/evento-lista/evento-lista.component';
import { EventosComponent } from './Componentes/eventos/eventos.component';
import { PalestrantesComponent } from './Componentes/palestrantes/palestrantes.component';
import { PerfilComponent } from './Componentes/Perfil/Perfil.component';

const routes: Routes = [
  { path: '', redirectTo: 'dashboard', pathMatch: 'full' },
  { path: '***', redirectTo: 'dashboard', pathMatch: 'full' },
  { path: 'dashboard', component: DashboardComponent },
  {
    path: 'eventos', component: EventosComponent,
    children:[
      { path: 'detalhe', component: EventoDetalheComponent },
      { path: 'detalhe/:id', component: EventoDetalheComponent },
      { path: 'lista', component: EventoListaComponent },
    ]
   },
  { path: 'palestrantes', component: PalestrantesComponent},
  { path: 'perfil', component: PerfilComponent},
  { path: 'contatos', component: ContatosComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
