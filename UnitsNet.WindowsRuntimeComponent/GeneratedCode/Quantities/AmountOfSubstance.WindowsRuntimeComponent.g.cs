﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by \generate-code.bat.
//
//     Changes to this file will be lost when the code is regenerated.
//     The build server regenerates the code before each build and a pre-build
//     step will regenerate the code on each local build.
//
//     See https://github.com/angularsen/UnitsNet/wiki/Adding-a-New-Unit for how to add or edit units.
//
//     Add CustomCode\Quantities\MyQuantity.extra.cs files to add code to generated quantities.
//     Add UnitDefinitions\MyQuantity.json and run generate-code.bat to generate new units or quantities.
//
// </auto-generated>
//------------------------------------------------------------------------------

// Copyright (c) 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com).
// https://github.com/angularsen/UnitsNet
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using System;
using System.Globalization;
using System.Linq;
using JetBrains.Annotations;
using UnitsNet.Units;
using UnitsNet.InternalHelpers;

// ReSharper disable once CheckNamespace

namespace UnitsNet
{
    /// <summary>
    ///     Mole is the amount of substance containing Avagadro's Number (6.02 x 10 ^ 23) of real particles such as molecules,atoms, ions or radicals.
    /// </summary>
    // Windows Runtime Component has constraints on public types: https://msdn.microsoft.com/en-us/library/br230301.aspx#Declaring types in Windows Runtime Components
    // Public structures can't have any members other than public fields, and those fields must be value types or strings.
    // Public classes must be sealed (NotInheritable in Visual Basic). If your programming model requires polymorphism, you can create a public interface and implement that interface on the classes that must be polymorphic.
    public sealed partial class AmountOfSubstance : IQuantity
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        private readonly double _value;

        /// <summary>
        ///     The unit this quantity was constructed with.
        /// </summary>
        private readonly AmountOfSubstanceUnit? _unit;

        static AmountOfSubstance()
        {
            BaseDimensions = new BaseDimensions(0, 0, 0, 0, 0, 1, 0);
            Info = new QuantityInfo(QuantityType.AmountOfSubstance, Units.Cast<Enum>().ToArray(), BaseUnit, Zero, BaseDimensions);
        }
        /// <summary>
        ///     Creates the quantity with a value of 0 in the base unit Mole.
        /// </summary>
        /// <remarks>
        ///     Windows Runtime Component requires a default constructor.
        /// </remarks>
        public AmountOfSubstance()
        {
            _value = 0;
            _unit = BaseUnit;
        }

        /// <summary>
        ///     Creates the quantity with the given numeric value and unit.
        /// </summary>
        /// <param name="numericValue">The numeric value  to contruct this quantity with.</param>
        /// <param name="unit">The unit representation to contruct this quantity with.</param>
        /// <remarks>Value parameter cannot be named 'value' due to constraint when targeting Windows Runtime Component.</remarks>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        private AmountOfSubstance(double numericValue, AmountOfSubstanceUnit unit)
        {
            if(unit == AmountOfSubstanceUnit.Undefined)
              throw new ArgumentException("The quantity can not be created with an undefined unit.", nameof(unit));

            _value = Guard.EnsureValidNumber(numericValue, nameof(numericValue));
            _unit = unit;
        }

        #region Static Properties

        /// <inheritdoc cref="IQuantity.QuantityInfo"/>
        internal static QuantityInfo Info { get; }

        /// <summary>
        ///     The <see cref="BaseDimensions" /> of this quantity.
        /// </summary>
        public static BaseDimensions BaseDimensions { get; }

        /// <summary>
        ///     The base unit of AmountOfSubstance, which is Mole. All conversions go via this value.
        /// </summary>
        public static AmountOfSubstanceUnit BaseUnit { get; } = AmountOfSubstanceUnit.Mole;

        /// <summary>
        /// Represents the largest possible value of AmountOfSubstance
        /// </summary>
        public static AmountOfSubstance MaxValue { get; } = new AmountOfSubstance(double.MaxValue, BaseUnit);

        /// <summary>
        /// Represents the smallest possible value of AmountOfSubstance
        /// </summary>
        public static AmountOfSubstance MinValue { get; } = new AmountOfSubstance(double.MinValue, BaseUnit);

        /// <summary>
        ///     The <see cref="QuantityType" /> of this quantity.
        /// </summary>
        public static QuantityType QuantityType { get; } = QuantityType.AmountOfSubstance;

        /// <summary>
        ///     All units of measurement for the AmountOfSubstance quantity.
        /// </summary>
        public static AmountOfSubstanceUnit[] Units { get; } = Enum.GetValues(typeof(AmountOfSubstanceUnit)).Cast<AmountOfSubstanceUnit>().Except(new AmountOfSubstanceUnit[]{ AmountOfSubstanceUnit.Undefined }).ToArray();

        /// <summary>
        ///     Gets an instance of this quantity with a value of 0 in the base unit Mole.
        /// </summary>
        public static AmountOfSubstance Zero { get; } = new AmountOfSubstance(0, BaseUnit);

        #endregion

        #region Properties

        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        public double Value => Convert.ToDouble(_value);

        /// <inheritdoc cref="IQuantity.Unit"/>
        object IQuantity.Unit => Unit;

        /// <summary>
        ///     The unit this quantity was constructed with -or- <see cref="BaseUnit" /> if default ctor was used.
        /// </summary>
        public AmountOfSubstanceUnit Unit => _unit.GetValueOrDefault(BaseUnit);

        internal QuantityInfo QuantityInfo => Info;

        /// <summary>
        ///     The <see cref="QuantityType" /> of this quantity.
        /// </summary>
        public QuantityType Type => AmountOfSubstance.QuantityType;

        /// <summary>
        ///     The <see cref="BaseDimensions" /> of this quantity.
        /// </summary>
        public BaseDimensions Dimensions => AmountOfSubstance.BaseDimensions;

        #endregion

        #region Conversion Properties

        /// <summary>
        ///     Get AmountOfSubstance in Centimoles.
        /// </summary>
        public double Centimoles => As(AmountOfSubstanceUnit.Centimole);

        /// <summary>
        ///     Get AmountOfSubstance in CentipoundMoles.
        /// </summary>
        public double CentipoundMoles => As(AmountOfSubstanceUnit.CentipoundMole);

        /// <summary>
        ///     Get AmountOfSubstance in Decimoles.
        /// </summary>
        public double Decimoles => As(AmountOfSubstanceUnit.Decimole);

        /// <summary>
        ///     Get AmountOfSubstance in DecipoundMoles.
        /// </summary>
        public double DecipoundMoles => As(AmountOfSubstanceUnit.DecipoundMole);

        /// <summary>
        ///     Get AmountOfSubstance in Kilomoles.
        /// </summary>
        public double Kilomoles => As(AmountOfSubstanceUnit.Kilomole);

        /// <summary>
        ///     Get AmountOfSubstance in KilopoundMoles.
        /// </summary>
        public double KilopoundMoles => As(AmountOfSubstanceUnit.KilopoundMole);

        /// <summary>
        ///     Get AmountOfSubstance in Megamoles.
        /// </summary>
        public double Megamoles => As(AmountOfSubstanceUnit.Megamole);

        /// <summary>
        ///     Get AmountOfSubstance in Micromoles.
        /// </summary>
        public double Micromoles => As(AmountOfSubstanceUnit.Micromole);

        /// <summary>
        ///     Get AmountOfSubstance in MicropoundMoles.
        /// </summary>
        public double MicropoundMoles => As(AmountOfSubstanceUnit.MicropoundMole);

        /// <summary>
        ///     Get AmountOfSubstance in Millimoles.
        /// </summary>
        public double Millimoles => As(AmountOfSubstanceUnit.Millimole);

        /// <summary>
        ///     Get AmountOfSubstance in MillipoundMoles.
        /// </summary>
        public double MillipoundMoles => As(AmountOfSubstanceUnit.MillipoundMole);

        /// <summary>
        ///     Get AmountOfSubstance in Moles.
        /// </summary>
        public double Moles => As(AmountOfSubstanceUnit.Mole);

        /// <summary>
        ///     Get AmountOfSubstance in Nanomoles.
        /// </summary>
        public double Nanomoles => As(AmountOfSubstanceUnit.Nanomole);

        /// <summary>
        ///     Get AmountOfSubstance in NanopoundMoles.
        /// </summary>
        public double NanopoundMoles => As(AmountOfSubstanceUnit.NanopoundMole);

        /// <summary>
        ///     Get AmountOfSubstance in PoundMoles.
        /// </summary>
        public double PoundMoles => As(AmountOfSubstanceUnit.PoundMole);

        #endregion

        #region Static Methods

        /// <summary>
        ///     Get unit abbreviation string.
        /// </summary>
        /// <param name="unit">Unit to get abbreviation for.</param>
        /// <returns>Unit abbreviation string.</returns>
        public static string GetAbbreviation(AmountOfSubstanceUnit unit)
        {
            return GetAbbreviation(unit, null);
        }

        /// <summary>
        ///     Get unit abbreviation string.
        /// </summary>
        /// <param name="unit">Unit to get abbreviation for.</param>
        /// <returns>Unit abbreviation string.</returns>
        /// <param name="cultureName">Name of culture (ex: "en-US") to use when parsing number and unit. Defaults to <see cref="GlobalConfiguration.DefaultCulture" /> if null.</param>
        public static string GetAbbreviation(AmountOfSubstanceUnit unit, [CanBeNull] string cultureName)
        {
            IFormatProvider provider = GetFormatProviderFromCultureName(cultureName);
            return UnitAbbreviationsCache.Default.GetDefaultAbbreviation(unit, provider);
        }

        #endregion

        #region Static Factory Methods

        /// <summary>
        ///     Get AmountOfSubstance from Centimoles.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Windows.Foundation.Metadata.DefaultOverload]
        public static AmountOfSubstance FromCentimoles(double centimoles)
        {
            double value = (double) centimoles;
            return new AmountOfSubstance(value, AmountOfSubstanceUnit.Centimole);
        }
        /// <summary>
        ///     Get AmountOfSubstance from CentipoundMoles.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Windows.Foundation.Metadata.DefaultOverload]
        public static AmountOfSubstance FromCentipoundMoles(double centipoundmoles)
        {
            double value = (double) centipoundmoles;
            return new AmountOfSubstance(value, AmountOfSubstanceUnit.CentipoundMole);
        }
        /// <summary>
        ///     Get AmountOfSubstance from Decimoles.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Windows.Foundation.Metadata.DefaultOverload]
        public static AmountOfSubstance FromDecimoles(double decimoles)
        {
            double value = (double) decimoles;
            return new AmountOfSubstance(value, AmountOfSubstanceUnit.Decimole);
        }
        /// <summary>
        ///     Get AmountOfSubstance from DecipoundMoles.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Windows.Foundation.Metadata.DefaultOverload]
        public static AmountOfSubstance FromDecipoundMoles(double decipoundmoles)
        {
            double value = (double) decipoundmoles;
            return new AmountOfSubstance(value, AmountOfSubstanceUnit.DecipoundMole);
        }
        /// <summary>
        ///     Get AmountOfSubstance from Kilomoles.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Windows.Foundation.Metadata.DefaultOverload]
        public static AmountOfSubstance FromKilomoles(double kilomoles)
        {
            double value = (double) kilomoles;
            return new AmountOfSubstance(value, AmountOfSubstanceUnit.Kilomole);
        }
        /// <summary>
        ///     Get AmountOfSubstance from KilopoundMoles.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Windows.Foundation.Metadata.DefaultOverload]
        public static AmountOfSubstance FromKilopoundMoles(double kilopoundmoles)
        {
            double value = (double) kilopoundmoles;
            return new AmountOfSubstance(value, AmountOfSubstanceUnit.KilopoundMole);
        }
        /// <summary>
        ///     Get AmountOfSubstance from Megamoles.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Windows.Foundation.Metadata.DefaultOverload]
        public static AmountOfSubstance FromMegamoles(double megamoles)
        {
            double value = (double) megamoles;
            return new AmountOfSubstance(value, AmountOfSubstanceUnit.Megamole);
        }
        /// <summary>
        ///     Get AmountOfSubstance from Micromoles.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Windows.Foundation.Metadata.DefaultOverload]
        public static AmountOfSubstance FromMicromoles(double micromoles)
        {
            double value = (double) micromoles;
            return new AmountOfSubstance(value, AmountOfSubstanceUnit.Micromole);
        }
        /// <summary>
        ///     Get AmountOfSubstance from MicropoundMoles.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Windows.Foundation.Metadata.DefaultOverload]
        public static AmountOfSubstance FromMicropoundMoles(double micropoundmoles)
        {
            double value = (double) micropoundmoles;
            return new AmountOfSubstance(value, AmountOfSubstanceUnit.MicropoundMole);
        }
        /// <summary>
        ///     Get AmountOfSubstance from Millimoles.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Windows.Foundation.Metadata.DefaultOverload]
        public static AmountOfSubstance FromMillimoles(double millimoles)
        {
            double value = (double) millimoles;
            return new AmountOfSubstance(value, AmountOfSubstanceUnit.Millimole);
        }
        /// <summary>
        ///     Get AmountOfSubstance from MillipoundMoles.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Windows.Foundation.Metadata.DefaultOverload]
        public static AmountOfSubstance FromMillipoundMoles(double millipoundmoles)
        {
            double value = (double) millipoundmoles;
            return new AmountOfSubstance(value, AmountOfSubstanceUnit.MillipoundMole);
        }
        /// <summary>
        ///     Get AmountOfSubstance from Moles.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Windows.Foundation.Metadata.DefaultOverload]
        public static AmountOfSubstance FromMoles(double moles)
        {
            double value = (double) moles;
            return new AmountOfSubstance(value, AmountOfSubstanceUnit.Mole);
        }
        /// <summary>
        ///     Get AmountOfSubstance from Nanomoles.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Windows.Foundation.Metadata.DefaultOverload]
        public static AmountOfSubstance FromNanomoles(double nanomoles)
        {
            double value = (double) nanomoles;
            return new AmountOfSubstance(value, AmountOfSubstanceUnit.Nanomole);
        }
        /// <summary>
        ///     Get AmountOfSubstance from NanopoundMoles.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Windows.Foundation.Metadata.DefaultOverload]
        public static AmountOfSubstance FromNanopoundMoles(double nanopoundmoles)
        {
            double value = (double) nanopoundmoles;
            return new AmountOfSubstance(value, AmountOfSubstanceUnit.NanopoundMole);
        }
        /// <summary>
        ///     Get AmountOfSubstance from PoundMoles.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Windows.Foundation.Metadata.DefaultOverload]
        public static AmountOfSubstance FromPoundMoles(double poundmoles)
        {
            double value = (double) poundmoles;
            return new AmountOfSubstance(value, AmountOfSubstanceUnit.PoundMole);
        }

        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="AmountOfSubstanceUnit" /> to <see cref="AmountOfSubstance" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>AmountOfSubstance unit value.</returns>
        // Fix name conflict with parameter "value"
        [return: System.Runtime.InteropServices.WindowsRuntime.ReturnValueName("returnValue")]
        public static AmountOfSubstance From(double value, AmountOfSubstanceUnit fromUnit)
        {
            return new AmountOfSubstance((double)value, fromUnit);
        }

        #endregion

        #region Static Parse Methods

        /// <summary>
        ///     Parse a string with one or two quantities of the format "&lt;quantity&gt; &lt;unit&gt;".
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <example>
        ///     Length.Parse("5.5 m", new CultureInfo("en-US"));
        /// </example>
        /// <exception cref="ArgumentNullException">The value of 'str' cannot be null. </exception>
        /// <exception cref="ArgumentException">
        ///     Expected string to have one or two pairs of quantity and unit in the format
        ///     "&lt;quantity&gt; &lt;unit&gt;". Eg. "5.5 m" or "1ft 2in"
        /// </exception>
        /// <exception cref="AmbiguousUnitParseException">
        ///     More than one unit is represented by the specified unit abbreviation.
        ///     Example: Volume.Parse("1 cup") will throw, because it can refer to any of
        ///     <see cref="VolumeUnit.MetricCup" />, <see cref="VolumeUnit.UsLegalCup" /> and <see cref="VolumeUnit.UsCustomaryCup" />.
        /// </exception>
        /// <exception cref="UnitsNetException">
        ///     If anything else goes wrong, typically due to a bug or unhandled case.
        ///     We wrap exceptions in <see cref="UnitsNetException" /> to allow you to distinguish
        ///     Units.NET exceptions from other exceptions.
        /// </exception>
        public static AmountOfSubstance Parse(string str)
        {
            return Parse(str, null);
        }

        /// <summary>
        ///     Parse a string with one or two quantities of the format "&lt;quantity&gt; &lt;unit&gt;".
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <example>
        ///     Length.Parse("5.5 m", new CultureInfo("en-US"));
        /// </example>
        /// <exception cref="ArgumentNullException">The value of 'str' cannot be null. </exception>
        /// <exception cref="ArgumentException">
        ///     Expected string to have one or two pairs of quantity and unit in the format
        ///     "&lt;quantity&gt; &lt;unit&gt;". Eg. "5.5 m" or "1ft 2in"
        /// </exception>
        /// <exception cref="AmbiguousUnitParseException">
        ///     More than one unit is represented by the specified unit abbreviation.
        ///     Example: Volume.Parse("1 cup") will throw, because it can refer to any of
        ///     <see cref="VolumeUnit.MetricCup" />, <see cref="VolumeUnit.UsLegalCup" /> and <see cref="VolumeUnit.UsCustomaryCup" />.
        /// </exception>
        /// <exception cref="UnitsNetException">
        ///     If anything else goes wrong, typically due to a bug or unhandled case.
        ///     We wrap exceptions in <see cref="UnitsNetException" /> to allow you to distinguish
        ///     Units.NET exceptions from other exceptions.
        /// </exception>
        /// <param name="cultureName">Name of culture (ex: "en-US") to use when parsing number and unit. Defaults to <see cref="GlobalConfiguration.DefaultCulture" /> if null.</param>
        public static AmountOfSubstance Parse(string str, [CanBeNull] string cultureName)
        {
            IFormatProvider provider = GetFormatProviderFromCultureName(cultureName);
            return QuantityParser.Default.Parse<AmountOfSubstance, AmountOfSubstanceUnit>(
                str,
                provider,
                From);
        }

        /// <summary>
        ///     Try to parse a string with one or two quantities of the format "&lt;quantity&gt; &lt;unit&gt;".
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <param name="result">Resulting unit quantity if successful.</param>
        /// <example>
        ///     Length.Parse("5.5 m", new CultureInfo("en-US"));
        /// </example>
        public static bool TryParse([CanBeNull] string str, out AmountOfSubstance result)
        {
            return TryParse(str, null, out result);
        }

        /// <summary>
        ///     Try to parse a string with one or two quantities of the format "&lt;quantity&gt; &lt;unit&gt;".
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <param name="result">Resulting unit quantity if successful.</param>
        /// <returns>True if successful, otherwise false.</returns>
        /// <example>
        ///     Length.Parse("5.5 m", new CultureInfo("en-US"));
        /// </example>
        /// <param name="cultureName">Name of culture (ex: "en-US") to use when parsing number and unit. Defaults to <see cref="GlobalConfiguration.DefaultCulture" /> if null.</param>
        public static bool TryParse([CanBeNull] string str, [CanBeNull] string cultureName, out AmountOfSubstance result)
        {
            IFormatProvider provider = GetFormatProviderFromCultureName(cultureName);
            return QuantityParser.Default.TryParse<AmountOfSubstance, AmountOfSubstanceUnit>(
                str,
                provider,
                From,
                out result);
        }

        /// <summary>
        ///     Parse a unit string.
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <example>
        ///     Length.ParseUnit("m", new CultureInfo("en-US"));
        /// </example>
        /// <exception cref="ArgumentNullException">The value of 'str' cannot be null. </exception>
        /// <exception cref="UnitsNetException">Error parsing string.</exception>
        public static AmountOfSubstanceUnit ParseUnit(string str)
        {
            return ParseUnit(str, null);
        }

        /// <summary>
        ///     Parse a unit string.
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <example>
        ///     Length.ParseUnit("m", new CultureInfo("en-US"));
        /// </example>
        /// <exception cref="ArgumentNullException">The value of 'str' cannot be null. </exception>
        /// <exception cref="UnitsNetException">Error parsing string.</exception>
        /// <param name="cultureName">Name of culture (ex: "en-US") to use when parsing number and unit. Defaults to <see cref="GlobalConfiguration.DefaultCulture" /> if null.</param>
        public static AmountOfSubstanceUnit ParseUnit(string str, [CanBeNull] string cultureName)
        {
            IFormatProvider provider = GetFormatProviderFromCultureName(cultureName);
            return UnitParser.Default.Parse<AmountOfSubstanceUnit>(str, provider);
        }

        public static bool TryParseUnit(string str, out AmountOfSubstanceUnit unit)
        {
            return TryParseUnit(str, null, out unit);
        }

        /// <summary>
        ///     Parse a unit string.
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <param name="unit">The parsed unit if successful.</param>
        /// <returns>True if successful, otherwise false.</returns>
        /// <example>
        ///     Length.TryParseUnit("m", new CultureInfo("en-US"));
        /// </example>
        /// <param name="cultureName">Name of culture (ex: "en-US") to use when parsing number and unit. Defaults to <see cref="GlobalConfiguration.DefaultCulture" /> if null.</param>
        public static bool TryParseUnit(string str, [CanBeNull] string cultureName, out AmountOfSubstanceUnit unit)
        {
            IFormatProvider provider = GetFormatProviderFromCultureName(cultureName);
            return UnitParser.Default.TryParse<AmountOfSubstanceUnit>(str, provider, out unit);
        }

        #endregion

        #region Equality / IComparable

        public int CompareTo(object obj)
        {
            if(obj is null) throw new ArgumentNullException(nameof(obj));
            if(!(obj is AmountOfSubstance objAmountOfSubstance)) throw new ArgumentException("Expected type AmountOfSubstance.", nameof(obj));

            return CompareTo(objAmountOfSubstance);
        }

        // Windows Runtime Component does not allow public methods/ctors with same number of parameters: https://msdn.microsoft.com/en-us/library/br230301.aspx#Overloaded methods
        internal int CompareTo(AmountOfSubstance other)
        {
            return _value.CompareTo(other.AsBaseNumericType(this.Unit));
        }

        [Windows.Foundation.Metadata.DefaultOverload]
        public override bool Equals(object obj)
        {
            if(obj is null || !(obj is AmountOfSubstance objAmountOfSubstance))
                return false;

            return Equals(objAmountOfSubstance);
        }

        public bool Equals(AmountOfSubstance other)
        {
            return _value.Equals(other.AsBaseNumericType(this.Unit));
        }

        /// <summary>
        ///     <para>
        ///     Compare equality to another AmountOfSubstance within the given absolute or relative tolerance.
        ///     </para>
        ///     <para>
        ///     Relative tolerance is defined as the maximum allowable absolute difference between this quantity's value and
        ///     <paramref name="other"/> as a percentage of this quantity's value. <paramref name="other"/> will be converted into
        ///     this quantity's unit for comparison. A relative tolerance of 0.01 means the absolute difference must be within +/- 1% of
        ///     this quantity's value to be considered equal.
        ///     <example>
        ///     In this example, the two quantities will be equal if the value of b is within +/- 1% of a (0.02m or 2cm).
        ///     <code>
        ///     var a = Length.FromMeters(2.0);
        ///     var b = Length.FromInches(50.0);
        ///     a.Equals(b, 0.01, ComparisonType.Relative);
        ///     </code>
        ///     </example>
        ///     </para>
        ///     <para>
        ///     Absolute tolerance is defined as the maximum allowable absolute difference between this quantity's value and
        ///     <paramref name="other"/> as a fixed number in this quantity's unit. <paramref name="other"/> will be converted into
        ///     this quantity's unit for comparison.
        ///     <example>
        ///     In this example, the two quantities will be equal if the value of b is within 0.01 of a (0.01m or 1cm).
        ///     <code>
        ///     var a = Length.FromMeters(2.0);
        ///     var b = Length.FromInches(50.0);
        ///     a.Equals(b, 0.01, ComparisonType.Absolute);
        ///     </code>
        ///     </example>
        ///     </para>
        ///     <para>
        ///     Note that it is advised against specifying zero difference, due to the nature
        ///     of floating point operations and using System.Double internally.
        ///     </para>
        /// </summary>
        /// <param name="other">The other quantity to compare to.</param>
        /// <param name="tolerance">The absolute or relative tolerance value. Must be greater than or equal to 0.</param>
        /// <param name="comparisonType">The comparison type: either relative or absolute.</param>
        /// <returns>True if the absolute difference between the two values is not greater than the specified relative or absolute tolerance.</returns>
        public bool Equals(AmountOfSubstance other, double tolerance, ComparisonType comparisonType)
        {
            if(tolerance < 0)
                throw new ArgumentOutOfRangeException("tolerance", "Tolerance must be greater than or equal to 0.");

            double thisValue = (double)this.Value;
            double otherValueInThisUnits = other.As(this.Unit);

            return UnitsNet.Comparison.Equals(thisValue, otherValueInThisUnits, tolerance, comparisonType);
        }

        /// <summary>
        ///     Returns the hash code for this instance.
        /// </summary>
        /// <returns>A hash code for the current AmountOfSubstance.</returns>
        public override int GetHashCode()
        {
            return new { QuantityType, Value, Unit }.GetHashCode();
        }

        #endregion

        #region Conversion Methods

        double IQuantity.As(object unit) => As((AmountOfSubstanceUnit)unit);

        /// <summary>
        ///     Convert to the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>Value converted to the specified unit.</returns>
        public double As(AmountOfSubstanceUnit unit)
        {
            if(Unit == unit)
                return Convert.ToDouble(Value);

            var converted = AsBaseNumericType(unit);
            return Convert.ToDouble(converted);
        }

        /// <summary>
        ///     Converts this AmountOfSubstance to another AmountOfSubstance with the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>A AmountOfSubstance with the specified unit.</returns>
        public AmountOfSubstance ToUnit(AmountOfSubstanceUnit unit)
        {
            var convertedValue = AsBaseNumericType(unit);
            return new AmountOfSubstance(convertedValue, unit);
        }

        /// <summary>
        ///     Converts the current value + unit to the base unit.
        ///     This is typically the first step in converting from one unit to another.
        /// </summary>
        /// <returns>The value in the base unit representation.</returns>
        private double AsBaseUnit()
        {
            switch(Unit)
            {
                case AmountOfSubstanceUnit.Centimole: return (_value) * 1e-2d;
                case AmountOfSubstanceUnit.CentipoundMole: return (_value*453.59237) * 1e-2d;
                case AmountOfSubstanceUnit.Decimole: return (_value) * 1e-1d;
                case AmountOfSubstanceUnit.DecipoundMole: return (_value*453.59237) * 1e-1d;
                case AmountOfSubstanceUnit.Kilomole: return (_value) * 1e3d;
                case AmountOfSubstanceUnit.KilopoundMole: return (_value*453.59237) * 1e3d;
                case AmountOfSubstanceUnit.Megamole: return (_value) * 1e6d;
                case AmountOfSubstanceUnit.Micromole: return (_value) * 1e-6d;
                case AmountOfSubstanceUnit.MicropoundMole: return (_value*453.59237) * 1e-6d;
                case AmountOfSubstanceUnit.Millimole: return (_value) * 1e-3d;
                case AmountOfSubstanceUnit.MillipoundMole: return (_value*453.59237) * 1e-3d;
                case AmountOfSubstanceUnit.Mole: return _value;
                case AmountOfSubstanceUnit.Nanomole: return (_value) * 1e-9d;
                case AmountOfSubstanceUnit.NanopoundMole: return (_value*453.59237) * 1e-9d;
                case AmountOfSubstanceUnit.PoundMole: return _value*453.59237;
                default:
                    throw new NotImplementedException($"Can not convert {Unit} to base units.");
            }
        }

        private double AsBaseNumericType(AmountOfSubstanceUnit unit)
        {
            if(Unit == unit)
                return _value;

            var baseUnitValue = AsBaseUnit();

            switch(unit)
            {
                case AmountOfSubstanceUnit.Centimole: return (baseUnitValue) / 1e-2d;
                case AmountOfSubstanceUnit.CentipoundMole: return (baseUnitValue/453.59237) / 1e-2d;
                case AmountOfSubstanceUnit.Decimole: return (baseUnitValue) / 1e-1d;
                case AmountOfSubstanceUnit.DecipoundMole: return (baseUnitValue/453.59237) / 1e-1d;
                case AmountOfSubstanceUnit.Kilomole: return (baseUnitValue) / 1e3d;
                case AmountOfSubstanceUnit.KilopoundMole: return (baseUnitValue/453.59237) / 1e3d;
                case AmountOfSubstanceUnit.Megamole: return (baseUnitValue) / 1e6d;
                case AmountOfSubstanceUnit.Micromole: return (baseUnitValue) / 1e-6d;
                case AmountOfSubstanceUnit.MicropoundMole: return (baseUnitValue/453.59237) / 1e-6d;
                case AmountOfSubstanceUnit.Millimole: return (baseUnitValue) / 1e-3d;
                case AmountOfSubstanceUnit.MillipoundMole: return (baseUnitValue/453.59237) / 1e-3d;
                case AmountOfSubstanceUnit.Mole: return baseUnitValue;
                case AmountOfSubstanceUnit.Nanomole: return (baseUnitValue) / 1e-9d;
                case AmountOfSubstanceUnit.NanopoundMole: return (baseUnitValue/453.59237) / 1e-9d;
                case AmountOfSubstanceUnit.PoundMole: return baseUnitValue/453.59237;
                default:
                    throw new NotImplementedException($"Can not convert {Unit} to {unit}.");
            }
        }

        #endregion

        #region ToString Methods

        /// <summary>
        ///     Get default string representation of value and unit.
        /// </summary>
        /// <returns>String representation.</returns>
        public override string ToString()
        {
            return ToString(null);
        }

        /// <summary>
        ///     Get string representation of value and unit. Using two significant digits after radix.
        /// </summary>
        /// <returns>String representation.</returns>
        /// <param name="cultureName">Name of culture (ex: "en-US") to use for localization and number formatting. Defaults to <see cref="GlobalConfiguration.DefaultCulture" /> if null.</param>
        public string ToString([CanBeNull] string cultureName)
        {
            var provider = cultureName;
            return ToString(provider, 2);
        }

        /// <summary>
        ///     Get string representation of value and unit.
        /// </summary>
        /// <param name="significantDigitsAfterRadix">The number of significant digits after the radix point.</param>
        /// <returns>String representation.</returns>
        /// <param name="cultureName">Name of culture (ex: "en-US") to use for localization and number formatting. Defaults to <see cref="GlobalConfiguration.DefaultCulture" /> if null.</param>
        public string ToString(string cultureName, int significantDigitsAfterRadix)
        {
            var provider = cultureName;
            var value = Convert.ToDouble(Value);
            var format = UnitFormatter.GetFormat(value, significantDigitsAfterRadix);
            return ToString(provider, format);
        }

        /// <summary>
        ///     Get string representation of value and unit.
        /// </summary>
        /// <param name="format">String format to use. Default:  "{0:0.##} {1} for value and unit abbreviation respectively."</param>
        /// <param name="args">Arguments for string format. Value and unit are implictly included as arguments 0 and 1.</param>
        /// <returns>String representation.</returns>
        /// <param name="cultureName">Name of culture (ex: "en-US") to use for localization and number formatting. Defaults to <see cref="GlobalConfiguration.DefaultCulture" /> if null.</param>
        public string ToString([CanBeNull] string cultureName, [NotNull] string format, [NotNull] params object[] args)
        {
            var provider = GetFormatProviderFromCultureName(cultureName);
            if (format == null) throw new ArgumentNullException(nameof(format));
            if (args == null) throw new ArgumentNullException(nameof(args));

            provider = provider ?? GlobalConfiguration.DefaultCulture;

            var value = Convert.ToDouble(Value);
            var formatArgs = UnitFormatter.GetFormatArgs(Unit, value, provider, args);
            return string.Format(provider, format, formatArgs);
        }

        #endregion

        private static IFormatProvider GetFormatProviderFromCultureName([CanBeNull] string cultureName)
        {
            return cultureName != null ? new CultureInfo(cultureName) : (IFormatProvider)null;
        }

    }
}
