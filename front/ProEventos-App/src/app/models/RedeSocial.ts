import { Evento } from "./Evento";
import { Palestrantes } from "./Palestrantes"

export interface RedeSocial {
  id: number;
  nome: string;
  url: string;
  eventoId?: number;
  evento: Evento;
  palestranteId?: number;
  palestrante: Palestrantes;
}
