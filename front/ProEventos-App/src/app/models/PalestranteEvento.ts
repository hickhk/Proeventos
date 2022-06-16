import { Palestrantes } from "./Palestrantes";

export interface PalestranteEvento {
  palestranteId: number;
  eventoId: number;
  palestrante: Palestrantes[];
  evento: Event;
}
