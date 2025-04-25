using System;
using System.Numerics;

namespace TI_3;

// Класс RSA содержит полезные математические функции,
// необходимые для реализации алгоритма RSA
static class RSA
{
	// Метод вычисляет значение функции Эйлера φ(n)
	public static BigInteger EulerPhi(BigInteger n)
	{
		BigInteger result = n; // Начальное значение φ(n) = n

		// Перебор всех возможных простых делителей n
		for (BigInteger p = 2; p * p <= n; ++p)
		{
			// Если p делит n
			if (n % p == 0)
			{
				// Делим n на p, пока делится
				while (n % p == 0)
				{
					n /= p;
				}

				// Умножаем результат на (1 - 1/p)
				result -= result / p;
			}
		}

		// Если после цикла осталось n > 1 (оно простое),
		// то это последний простой множитель
		if (n > 1)
		{
			result -= result / n;
		}

		return result; // Возвращаем значение φ(n)
	}

	// Проверка, является ли число простым
	public static bool IsPrime(BigInteger number)
	{
		if (number <= 1)
			return false;
		if (number <= 3)
			return true;

		// Исключаем кратность 2 и 3
		if (number % 2 == 0 || number % 3 == 0)
			return false;

		// Проверяем делимость от 5 до sqrt(number) с шагом 6 (оптимизация)
		for (BigInteger i = 5; i * i <= number; i += 6)
		{
			if (number % i == 0 || number % (i + 2) == 0)
				return false;
		}

		return true;
	}

	// Нахождение наибольшего общего делителя (НОД) по алгоритму Евклида
	public static BigInteger FindGcd(BigInteger a, BigInteger b) => b == 0 ? a : FindGcd(b, a % b);

	// Расширенный алгоритм Евклида
	// Находит такие x и y, что: a*x + b*y = gcd(a, b)
	public static (BigInteger gcd, BigInteger x, BigInteger y) ExtendedEuclidean(BigInteger a, BigInteger b)
	{
		BigInteger x0 = 1, y0 = 0, x1 = 0, y1 = 1; // Начальные коэффициенты
		BigInteger d0 = a, d1 = b; // d0 - текущий НОД, d1 - остаток

		// Основной цикл алгоритма
		while (d1 != 0)
		{
			BigInteger q = d0 / d1; // Частное
			BigInteger d2 = d0 % d1; // Остаток
			BigInteger x2 = x0 - q * x1; // Обновление x
			BigInteger y2 = y0 - q * y1; // Обновление y

			// Сдвигаем значения на шаг
			d0 = d1;
			d1 = d2;
			x0 = x1;
			x1 = x2;
			y0 = y1;
			y1 = y2;
		}

		// Приведение y0 в положительное значение по модулю a
		if (y0 < 0)
		{
			y0 += a;
		}

		// Возвращаем НОД и коэффициенты x, y
		return (d0, x0, y0);
	}

	// Быстрое возведение в степень по модулю (алгоритм "быстрого возведения в степень")
	public static BigInteger QuickPowerMod(BigInteger num, BigInteger power, BigInteger mod)
	{
		// Обработка частных случаев
		if (mod == 1)
			return 0;

		if (power == 0)
			return 1;

		if (num == 0)
			return 0;

		BigInteger result = 1; // Начальный результат
		BigInteger current = num % mod; // Текущая база
		BigInteger exponent = power; // Степень

		// Алгоритм "двоичного возведения в степень"
		while (exponent > 0)
		{
			// Если текущий бит степени = 1
			if (exponent % 2 == 1)
				result = (result * current) % mod;

			current = (current * current) % mod; // Возводим базу в квадрат
			exponent /= 2; // Переходим к следующему биту
		}

		return result; // Возвращаем результат
	}
}
