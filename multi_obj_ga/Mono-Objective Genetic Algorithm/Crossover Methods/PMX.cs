﻿using Genetic_Algorithm_Commons;

namespace Mono_Objective_Genetic_Algorithm.Crossover_Methods {
    public class PMX : CrossoverMethodBase {
        public override void Execute(IndividualBase parent1, IndividualBase parent2, out IndividualBase child1, out IndividualBase child2) {
            Problem.PMXCrossover(parent1, parent2, out child1, out child2);
        }
    }
}
