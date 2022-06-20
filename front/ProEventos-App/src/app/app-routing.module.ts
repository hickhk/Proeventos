import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ContatosComponent } from './Componentes/Contatos/Contatos.component';
import { DashboardComponent } from './Componentes/Dashboard/Dashboard.component';
import { EventosComponent } from './Componentes/eventos/eventos.component';
import { PalestrantesComponent } from './Componentes/palestrantes/palestrantes.component';
import { PerfilComponent } from './Componentes/Perfil/Perfil.component';

const routes: Routes = [
  { path: '', redirectTo: 'dashboard', pathMatch: 'full' },
  { path: '***', redirectTo: 'dashboard', pathMatch: 'full' },
  { path: 'dashboard', component: DashboardComponent },
  { path: 'eventos', component: EventosComponent },
  { path: 'palestrantes', component: PalestrantesComponent},
  { path: 'perfil', component: PerfilComponent},
  { path: 'contatos', component: ContatosComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
