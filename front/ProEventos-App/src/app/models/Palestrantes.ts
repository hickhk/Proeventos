import { PalestranteEvento } from "./PalestranteEvento";
import { RedeSocial } from "./RedeSocial";

export interface Palestrantes {
  id: number;
  nome: string;
  miniCurriculo: string;
  foto: string;
  telefone: string;
  email: string;
  redesSociais: RedeSocial[];
  palestrantesEventos: PalestranteEvento[];
}
