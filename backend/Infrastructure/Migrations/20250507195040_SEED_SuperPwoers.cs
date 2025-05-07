using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SEED_SuperPwoers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"INSERT INTO SuperPowers (SuperPower, Description, Deleted) VALUES
                                  ('Invisibilidade', 'Capacidade de ficar invisível aos olhos humanos.', 0),
                                  ('Voo', 'Habilidade de voar sem auxílio de equipamentos.', 0),
                                  ('Super Força', 'Força física muito acima do normal.', 0),
                                  ('Telepatia', 'Capacidade de ler e se comunicar com mentes.', 0),
                                  ('Viagem no Tempo', 'Capacidade de viajar para o passado ou futuro.', 0),
                                  ('Telecinese', 'Mover objetos com a mente.', 0),
                                  ('Mudar de Forma', 'Alterar a própria aparência ou corpo.', 0),
                                  ('Fator de Cura', 'Recuperação extremamente rápida de ferimentos.', 0),
                                  ('Visão de Raio-X', 'Enxergar através de objetos sólidos.', 0),
                                  ('Velocidade Sobrehumana', 'Correr em velocidades muito acima do normal.', 0),
                                  ('Manipulação de Fogo', 'Criar e controlar o fogo.', 0),
                                  ('Controle da Água', 'Manipular e moldar a água.', 0),
                                  ('Criocinese', 'Habilidade de gerar e controlar o gelo.', 0),
                                  ('Controle da Terra', 'Manipular rochas, terra e minerais.', 0),
                                  ('Ficar Gigante', 'Aumentar o tamanho do próprio corpo.', 0),
                                  ('Ficar Minúsculo', 'Reduzir o tamanho até o nível microscópico.', 0),
                                  ('Respirar debaixo da água', 'Capacidade de respirar normalmente submerso.', 0),
                                  ('Invulnerabilidade', 'Resistência extrema a danos físicos.', 0),
                                  ('Manipulação do Tempo', 'Abrandar ou acelerar o tempo ao redor.', 0),
                                  ('Criação de Ilusões', 'Capacidade de criar ilusões realistas para enganar.', 0);");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
