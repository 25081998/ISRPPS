using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursGeneticAlgorithm
{
    //абстрактный продукт
    public abstract class AbstractProduct
    {
        public abstract string Information();
    }
    //конкретный продукт
    public class Algorithm : AbstractProduct
    {
        public override string Information()
        {
            return
                @"			The Genetic Algorithm with Elitism
	ЗАДАЧА
В примере кода задается тестовая функция для выработки соответствующего графика.
	АЛГОРИТМ
Код алгоритма содержит два простых класса, GeneticAlgorithm и Chromosome, плюс вспомогательный класс ChromosomeComparer.
Класс Chromosome можно считать простым контейнером. Нижележащая структура является массивом вещественных чисел двойной точности в диапазоне от 0 до 1. Ожидается, что пользователь берет эти значения и масштабирует их до любых нужных значений. Так как мутация происходит в хромосоме, метод Mutate находится в этом классе. Оператор кроссовера требует доступа к закрытым данным хромосомы, поэтому он является функцией-членом, принимающей вторую хромосому и выдающей две дочерних хромосомы. Пригодность конкретной хромосомы также хранится в хромосоме. В коде есть еще дополнительные вспомогательные функции.

Класс GeneticAlgorithm делает всю работу. Генетический алгоритм состоит из следующих базовых шагов:
1. Создать новую популяцию
2. Выбрать двух индивидуумов из популяции, взвешивая относительно индивидуума, представляющего лучшее на настоящий момент решение.
3. 'Размножить' их, чтобы произвести потомство.
4. Если нет достаточного потомства для новой популяции, вернуться к шагу 2.
5. Заменить старую популяцию новой.
6. Если не было произведено достаточно поколений, вернуться к шагу 2.
7. Конец.

Индивидуумы для размножения выбираются с помощью метода колеса рулетки. Более подходящие индивидуумы имеют более крупную часть 'колеса' и выбираются с большей вероятностью.";
        }
    }
    //конкретный продукт
    public class English : AbstractProduct
    {
        public override string Information()
        {
            return
                @"		Algorithm 33. The Genetic Algorithm with Elitism 
Elitism is simple: we augment the Genetic Algorithm to directly inject into the next population the  ﬁttest individual or individuals from the previous population. These individuals are called the  elites. By keeping the best individual (or individuals) around in future populations, this algorithm  begins to resemble (µ + l), and has similar exploitation properties. This exploitation can cause premature convergence if not kept in check: perhaps by increasing the mutation and crossover noise, or weakening the selection pressure, or reducing how many elites are being stored. A minor catch. If you want to maintain a population size of popsize, and you’re doing crossover,  you’ll need to have popsize, minus the number of elites, be divisible by two, as in this algorithm: 
1: popsize <- desired population size 
2: n <- desired number of elite individuals (popsizen should be even) 
3: P <- {} 
4: for popsize times do 
5:      P <- P[{new random individual} 
6: Best <- res 
7: repeat 
8:      for each individual Pi 2 P do 
9:          AssessFitness(Pi) 
10:         if Best = res or Fitness(Pi) > Fitness(Best) then 
11:             Best <- Pi 
12:     Q <- {the n ﬁttest individuals in P, breaking ties at random} 
13:     for (popsize - n)/2 times do 
14:         Parent Pa <- SelectWithReplacement(P) 
15:         Parent Pb <- SelectWithReplacement(P) 
16:         Children Ca,Cb <- Crossover(Copy(Pa), Copy(Pb)) 
17:         Q <- Q[{Mutate(Ca),Mutate(Cb)} 
18:     P <- Q 
19: until Best is the ideal solution or we have run out of time 
20: return Best
";
        }
    }
}
