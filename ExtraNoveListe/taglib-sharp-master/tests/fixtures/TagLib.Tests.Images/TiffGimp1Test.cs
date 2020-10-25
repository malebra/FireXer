// TODO: This file is automatically generated
// TODO: Further manual verification is needed

using System;
using NUnit.Framework;
using TagLib.IFD;
using TagLib.IFD.Entries;
using TagLib.IFD.Tags;
using TagLib.Xmp;
using TagLib.Tests.Images.Validators;

namespace TagLib.Tests.Images
{
	[TestFixture]
	public class TiffGimp1Test
	{
		[Test]
		public void Test ()
		{
			ImageTest.Run ("sample_gimp_lzw.tiff",
				ImageTest.CompareLargeImages,
				new TiffGimp1TestInvariantValidator (),
				NoModificationValidator.Instance
			);
		}
	}

	public class TiffGimp1TestInvariantValidator : IMetadataInvariantValidator
	{
		public void ValidateMetadataInvariants (Image.File file)
		{
			Assert.IsNotNull (file);
			//  ---------- Start of IFD tests ----------

			var tag = file.GetTag (TagTypes.TiffIFD) as IFDTag;
			Assert.IsNotNull (tag, "IFD tag not found");

			var structure = tag.Structure;

			// Image.0x00FE (NewSubfileType/Long/1) "0"
			{
				var entry = structure.GetEntry (0, (ushort) IFDEntryTag.NewSubfileType);
				Assert.IsNotNull (entry, "Entry 0x00FE missing in IFD 0");
				Assert.IsNotNull (entry as LongIFDEntry, "Entry is not a long!");
				Assert.AreEqual (0, (entry as LongIFDEntry).Value);
			}
			// Image.0x0100 (ImageWidth/Short/1) "1360"
			{
				var entry = structure.GetEntry (0, (ushort) IFDEntryTag.ImageWidth);
				Assert.IsNotNull (entry, "Entry 0x0100 missing in IFD 0");
				Assert.IsNotNull (entry as ShortIFDEntry, "Entry is not a short!");
				Assert.AreEqual (1360, (entry as ShortIFDEntry).Value);
			}
			// Image.0x0101 (ImageLength/Short/1) "1060"
			{
				var entry = structure.GetEntry (0, (ushort) IFDEntryTag.ImageLength);
				Assert.IsNotNull (entry, "Entry 0x0101 missing in IFD 0");
				Assert.IsNotNull (entry as ShortIFDEntry, "Entry is not a short!");
				Assert.AreEqual (1060, (entry as ShortIFDEntry).Value);
			}
			// Image.0x0102 (BitsPerSample/Short/3) "8 8 8"
			{
				var entry = structure.GetEntry (0, (ushort) IFDEntryTag.BitsPerSample);
				Assert.IsNotNull (entry, "Entry 0x0102 missing in IFD 0");
				Assert.IsNotNull (entry as ShortArrayIFDEntry, "Entry is not a short array!");
				Assert.AreEqual (new ushort [] { 8, 8, 8 }, (entry as ShortArrayIFDEntry).Values);
			}
			// Image.0x0103 (Compression/Short/1) "5"
			{
				var entry = structure.GetEntry (0, (ushort) IFDEntryTag.Compression);
				Assert.IsNotNull (entry, "Entry 0x0103 missing in IFD 0");
				Assert.IsNotNull (entry as ShortIFDEntry, "Entry is not a short!");
				Assert.AreEqual (5, (entry as ShortIFDEntry).Value);
			}
			// Image.0x0106 (PhotometricInterpretation/Short/1) "2"
			{
				var entry = structure.GetEntry (0, (ushort) IFDEntryTag.PhotometricInterpretation);
				Assert.IsNotNull (entry, "Entry 0x0106 missing in IFD 0");
				Assert.IsNotNull (entry as ShortIFDEntry, "Entry is not a short!");
				Assert.AreEqual (2, (entry as ShortIFDEntry).Value);
			}
			// Image.0x010D (DocumentName/Ascii/29) "/home/mike/sample_gimp1.tiff"
			{
				var entry = structure.GetEntry (0, (ushort) IFDEntryTag.DocumentName);
				Assert.IsNotNull (entry, "Entry 0x010D missing in IFD 0");
				Assert.IsNotNull (entry as StringIFDEntry, "Entry is not a string!");
				Assert.AreEqual ("/home/mike/sample_gimp1.tiff", (entry as StringIFDEntry).Value);
			}
			// Image.0x0111 (StripOffsets/StripOffsets/17) "8 92872 183535 274522 365281 454644 534266 611421 690373 775508 867104 965719 1071407 1175890 1280880 1386423 1477280"
			{
				var entry = structure.GetEntry (0, (ushort) IFDEntryTag.StripOffsets);
				Assert.IsNotNull (entry, "Entry 0x0111 missing in IFD 0");
				Assert.IsNotNull (entry as StripOffsetsIFDEntry, "Entry is not a strip offsets entry!");
				Assert.AreEqual (17, (entry as StripOffsetsIFDEntry).Values.Length);
			}
			// Image.0x0112 (Orientation/Short/1) "1"
			{
				var entry = structure.GetEntry (0, (ushort) IFDEntryTag.Orientation);
				Assert.IsNotNull (entry, "Entry 0x0112 missing in IFD 0");
				Assert.IsNotNull (entry as ShortIFDEntry, "Entry is not a short!");
				Assert.AreEqual (1, (entry as ShortIFDEntry).Value);
			}
			// Image.0x0115 (SamplesPerPixel/Short/1) "3"
			{
				var entry = structure.GetEntry (0, (ushort) IFDEntryTag.SamplesPerPixel);
				Assert.IsNotNull (entry, "Entry 0x0115 missing in IFD 0");
				Assert.IsNotNull (entry as ShortIFDEntry, "Entry is not a short!");
				Assert.AreEqual (3, (entry as ShortIFDEntry).Value);
			}
			// Image.0x0116 (RowsPerStrip/Short/1) "64"
			{
				var entry = structure.GetEntry (0, (ushort) IFDEntryTag.RowsPerStrip);
				Assert.IsNotNull (entry, "Entry 0x0116 missing in IFD 0");
				Assert.IsNotNull (entry as ShortIFDEntry, "Entry is not a short!");
				Assert.AreEqual (64, (entry as ShortIFDEntry).Value);
			}
			// Image.0x0117 (StripByteCounts/Long/17) "92864 90663 90987 90759 89363 79622 77155 78952 85135 91596 98615 105688 104483 104990 105543 90857 44330"
			{
				var entry = structure.GetEntry (0, (ushort) IFDEntryTag.StripByteCounts);
				Assert.IsNotNull (entry, "Entry 0x0117 missing in IFD 0");
				Assert.IsNotNull (entry as LongArrayIFDEntry, "Entry is not a long array!");
				Assert.AreEqual (new long [] { 92864, 90663, 90987, 90759, 89363, 79622, 77155, 78952, 85135, 91596, 98615, 105688, 104483, 104990, 105543, 90857, 44330 }, (entry as LongArrayIFDEntry).Values);
			}
			// Image.0x011A (XResolution/Rational/1) "1207959552/16777216"
			{
				var entry = structure.GetEntry (0, (ushort) IFDEntryTag.XResolution);
				Assert.IsNotNull (entry, "Entry 0x011A missing in IFD 0");
				Assert.IsNotNull (entry as RationalIFDEntry, "Entry is not a rational!");
				Assert.AreEqual (1207959552, (entry as RationalIFDEntry).Value.Numerator);
				Assert.AreEqual (16777216, (entry as RationalIFDEntry).Value.Denominator);
			}
			// Image.0x011B (YResolution/Rational/1) "1207959552/16777216"
			{
				var entry = structure.GetEntry (0, (ushort) IFDEntryTag.YResolution);
				Assert.IsNotNull (entry, "Entry 0x011B missing in IFD 0");
				Assert.IsNotNull (entry as RationalIFDEntry, "Entry is not a rational!");
				Assert.AreEqual (1207959552, (entry as RationalIFDEntry).Value.Numerator);
				Assert.AreEqual (16777216, (entry as RationalIFDEntry).Value.Denominator);
			}
			// Image.0x011C (PlanarConfiguration/Short/1) "1"
			{
				var entry = structure.GetEntry (0, (ushort) IFDEntryTag.PlanarConfiguration);
				Assert.IsNotNull (entry, "Entry 0x011C missing in IFD 0");
				Assert.IsNotNull (entry as ShortIFDEntry, "Entry is not a short!");
				Assert.AreEqual (1, (entry as ShortIFDEntry).Value);
			}
			// Image.0x0128 (ResolutionUnit/Short/1) "2"
			{
				var entry = structure.GetEntry (0, (ushort) IFDEntryTag.ResolutionUnit);
				Assert.IsNotNull (entry, "Entry 0x0128 missing in IFD 0");
				Assert.IsNotNull (entry as ShortIFDEntry, "Entry is not a short!");
				Assert.AreEqual (2, (entry as ShortIFDEntry).Value);
			}
			// Image.0x013D (0x013d/Short/1) "2"
			{
				var entry = structure.GetEntry (0, (ushort) IFDEntryTag.Predictor);
				Assert.IsNotNull (entry, "Entry 0x013D missing in IFD 0");
				Assert.IsNotNull (entry as ShortIFDEntry, "Entry is not a short!");
				Assert.AreEqual (2, (entry as ShortIFDEntry).Value);
			}
			// Image.0x8773 (InterColorProfile/Undefined/3140) "0 0 12 68 85 67 67 77 2 64 0 0 109 110 116 114 82 71 66 32 88 89 90 32 7 211 0 4 0 4 0 0 0 0 0 0 97 99 115 112 77 83 70 84 0 0 0 0 67 65 78 79 90 48 48 57 0 0 0 0 0 0 0 0 0 0 0 0 0 0 246 214 0 1 0 0 0 0 211 45 67 65 78 79 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 14 114 84 82 67 0 0 1 44 0 0 8 12 103 84 82 67 0 0 1 44 0 0 8 12 98 84 82 67 0 0 1 44 0 0 8 12 114 88 89 90 0 0 9 56 0 0 0 20 103 88 89 90 0 0 9 76 0 0 0 20 98 88 89 90 0 0 9 96 0 0 0 20 99 104 97 100 0 0 9 116 0 0 0 44 99 112 114 116 0 0 9 160 0 0 0 64 100 109 110 100 0 0 9 224 0 0 0 124 100 109 100 100 0 0 10 92 0 0 0 148 119 116 112 116 0 0 10 240 0 0 0 20 116 101 99 104 0 0 11 4 0 0 0 12 100 101 115 99 0 0 10 92 0 0 0 148 117 99 109 73 0 0 11 16 0 0 1 52 99 117 114 118 0 0 0 0 0 0 4 0 0 0 0 4 0 9 0 14 0 19 0 24 0 29 0 34 0 39 0 44 0 49 0 54 0 59 0 64 0 69 0 74 0 79 0 84 0 89 0 94 0 99 0 104 0 109 0 114 0 118 0 123 0 128 0 133 0 138 0 143 0 148 0 153 0 158 0 163 0 168 0 173 0 178 0 183 0 188 0 193 0 198 0 203 0 208 0 213 0 218 0 223 0 229 0 234 0 240 0 245 0 251 1 1 1 6 1 12 1 18 1 24 1 30 1 36 1 43 1 49 1 55 1 62 1 68 1 75 1 82 1 89 1 95 1 102 1 109 1 117 1 124 1 131 1 138 1 146 1 153 1 161 1 169 1 176 1 184 1 192 1 200 1 208 1 216 1 225 1 233 1 241 1 250 2 2 2 11 2 20 2 29 2 38 2 47 2 56 2 65 2 74 2 83 2 93 2 102 2 112 2 122 2 131 2 141 2 151 2 161 2 172 2 182 2 192 2 202 2 213 2 224 2 234 2 245 3 0 3 11 3 22 3 33 3 44 3 55 3 67 3 78 3 90 3 102 3 113 3 125 3 137 3 149 3 161 3 173 3 186 3 198 3 211 3 223 3 236 3 249 4 6 4 19 4 32 4 45 4 58 4 71 4 85 4 98 4 112 4 126 4 140 4 154 4 168 4 182 4 196 4 210 4 225 4 239 4 254 5 13 5 27 5 42 5 57 5 72 5 88 5 103 5 118 5 134 5 149 5 165 5 181 5 197 5 213 5 229 5 245 6 5 6 22 6 38 6 55 6 72 6 88 6 105 6 122 6 139 6 157 6 174 6 191 6 209 6 227 6 244 7 6 7 24 7 42 7 60 7 79 7 97 7 115 7 134 7 153 7 171 7 190 7 209 7 228 7 248 8 11 8 30 8 50 8 69 8 89 8 109 8 129 8 149 8 169 8 190 8 210 8 230 8 251 9 16 9 36 9 57 9 78 9 100 9 121 9 142 9 164 9 185 9 207 9 229 9 251 10 17 10 39 10 61 10 83 10 106 10 128 10 151 10 174 10 197 10 220 10 243 11 10 11 33 11 57 11 80 11 104 11 128 11 152 11 176 11 200 11 224 11 249 12 17 12 42 12 66 12 91 12 116 12 141 12 166 12 192 12 217 12 242 13 12 13 38 13 64 13 90 13 116 13 142 13 168 13 195 13 221 13 248 14 19 14 46 14 73 14 100 14 127 14 154 14 182 14 209 14 237 15 9 15 37 15 65 15 93 15 121 15 150 15 178 15 207 15 236 16 9 16 38 16 67 16 96 16 125 16 155 16 185 16 214 16 244 17 18 17 48 17 78 17 109 17 139 17 170 17 200 17 231 18 6 18 37 18 68 18 100 18 131 18 163 18 194 18 226 19 2 19 34 19 66 19 99 19 131 19 164 19 196 19 229 20 6 20 39 20 72 20 105 20 139 20 172 20 206 20 240 21 17 21 52 21 86 21 120 21 154 21 189 21 223 22 2 22 37 22 72 22 107 22 143 22 178 22 213 22 249 23 29 23 65 23 101 23 137 23 173 23 210 23 246 24 27 24 64 24 101 24 138 24 175 24 212 24 250 25 31 25 69 25 107 25 145 25 183 25 221 26 3 26 42 26 80 26 119 26 158 26 197 26 236 27 19 27 59 27 98 27 138 27 177 27 217 28 1 28 41 28 82 28 122 28 163 28 203 28 244 29 29 29 70 29 111 29 153 29 194 29 236 30 22 30 63 30 105 30 147 30 190 30 232 31 19 31 61 31 104 31 147 31 190 31 233 32 21 32 64 32 108 32 151 32 195 32 239 33 27 33 72 33 116 33 161 33 205 33 250 34 39 34 84 34 129 34 175 34 220 35 10 35 55 35 101 35 147 35 194 35 240 36 30 36 77 36 124 36 170 36 217 37 8 37 56 37 103 37 151 37 198 37 246 38 38 38 86 38 134 38 183 38 231 39 24 39 73 39 121 39 170 39 220 40 13 40 62 40 112 40 162 40 212 41 6 41 56 41 106 41 157 41 207 42 2 42 53 42 104 42 155 42 206 43 1 43 53 43 105 43 157 43 209 44 5 44 57 44 109 44 162 44 215 45 11 45 64 45 117 45 171 45 224 46 22 46 75 46 129 46 183 46 237 47 35 47 90 47 144 47 199 47 254 48 53 48 108 48 163 48 218 49 18 49 74 49 129 49 185 49 241 50 42 50 98 50 155 50 211 51 12 51 69 51 126 51 183 51 241 52 42 52 100 52 158 52 216 53 18 53 76 53 135 53 193 53 252 54 55 54 114 54 173 54 232 55 36 55 95 55 155 55 215 56 19 56 79 56 140 56 200 57 5 57 65 57 126 57 187 57 249 58 54 58 115 58 177 58 239 59 45 59 107 59 169 59 231 60 38 60 101 60 164 60 227 61 34 61 97 61 160 61 224 62 32 62 96 62 160 62 224 63 32 63 97 63 161 63 226 64 35 64 100 64 165 64 231 65 40 65 106 65 172 65 238 66 48 66 114 66 180 66 247 67 58 67 125 67 192 68 3 68 70 68 138 68 205 69 17 69 85 69 153 69 221 70 34 70 102 70 171 70 240 71 53 71 122 71 191 72 5 72 74 72 144 72 214 73 28 73 98 73 169 73 239 74 54 74 125 74 196 75 11 75 82 75 154 75 225 76 41 76 113 76 185 77 2 77 74 77 146 77 219 78 36 78 109 78 182 79 0 79 73 79 147 79 220 80 38 80 112 80 187 81 5 81 80 81 154 81 229 82 48 82 124 82 199 83 18 83 94 83 170 83 246 84 66 84 142 84 219 85 39 85 116 85 193 86 14 86 91 86 169 86 246 87 68 87 146 87 224 88 46 88 124 88 203 89 26 89 104 89 183 90 7 90 86 90 165 90 245 91 69 91 149 91 229 92 53 92 133 92 214 93 39 93 119 93 201 94 26 94 107 94 189 95 14 95 96 95 178 96 4 96 87 96 169 96 252 97 79 97 162 97 245 98 72 98 155 98 239 99 67 99 151 99 235 100 63 100 148 100 232 101 61 101 146 101 231 102 60 102 146 102 231 103 61 103 147 103 233 104 63 104 149 104 236 105 67 105 153 105 240 106 72 106 159 106 247 107 78 107 166 107 254 108 86 108 175 109 7 109 96 109 185 110 17 110 107 110 196 111 29 111 119 111 209 112 43 112 133 112 223 113 58 113 148 113 239 114 74 114 165 115 1 115 92 115 184 116 19 116 111 116 204 117 40 117 132 117 225 118 62 118 155 118 248 119 85 119 179 120 16 120 110 120 204 121 42 121 136 121 231 122 69 122 164 123 3 123 98 123 193 124 33 124 129 124 224 125 64 125 160 126 1 126 97 126 194 127 35 127 132 127 229 128 70 128 168 129 9 129 107 129 205 130 47 130 145 130 244 131 87 131 185 132 28 132 128 132 227 133 70 133 170 134 14 134 114 134 214 135 58 135 159 136 4 136 104 136 205 137 51 137 152 137 254 138 99 138 201 139 47 139 149 139 252 140 98 140 201 141 48 141 151 141 254 142 102 142 205 143 53 143 157 144 5 144 109 144 214 145 63 145 167 146 16 146 121 146 227 147 76 147 182 148 32 148 138 148 244 149 94 149 201 150 51 150 158 151 9 151 117 151 224 152 76 152 183 153 35 153 143 153 251 154 104 154 213 155 65 155 174 156 27 156 137 156 246 157 100 157 210 158 64 158 174 159 28 159 139 159 249 160 104 160 215 161 70 161 182 162 37 162 149 163 5 163 117 163 229 164 86 164 198 165 55 165 168 166 25 166 139 166 252 167 110 167 224 168 82 168 196 169 54 169 169 170 28 170 142 171 2 171 117 171 232 172 92 172 208 173 68 173 184 174 44 174 161 175 21 175 138 175 255 176 116 176 234 177 95 177 213 178 75 178 193 179 55 179 174 180 36 180 155 181 18 181 137 182 1 182 120 182 240 183 104 183 224 184 88 184 209 185 73 185 194 186 59 186 180 187 45 187 167 188 33 188 154 189 20 189 143 190 9 190 132 190 254 191 121 191 244 192 112 192 235 193 103 193 227 194 95 194 219 195 87 195 212 196 81 196 205 197 75 197 200 198 69 198 195 199 65 199 191 200 61 200 187 201 58 201 185 202 56 202 183 203 54 203 181 204 53 204 181 205 53 205 181 206 53 206 182 207 55 207 184 208 57 208 186 209 59 209 189 210 63 210 193 211 67 211 197 212 72 212 203 213 78 213 209 214 84 214 216 215 91 215 223 216 99 216 231 217 108 217 240 218 117 218 250 219 127 220 4 220 138 221 16 221 150 222 28 222 162 223 40 223 175 224 54 224 189 225 68 225 203 226 83 226 218 227 98 227 234 228 115 228 251 229 132 230 13 230 150 231 31 231 168 232 50 232 188 233 70 233 208 234 90 234 229 235 111 235 250 236 133 237 16 237 156 238 39 238 179 239 63 239 203 240 88 240 228 241 113 241 254 242 139 243 25 243 166 244 52 244 194 245 80 245 222 246 108 246 251 247 138 248 25 248 168 249 55 249 199 250 87 250 231 251 119 252 7 252 152 253 40 253 185 254 74 254 219 255 109 255 255 88 89 90 32 0 0 0 0 0 0 111 160 0 0 56 242 0 0 3 143 88 89 90 32 0 0 0 0 0 0 98 150 0 0 183 138 0 0 24 218 88 89 90 32 0 0 0 0 0 0 36 160 0 0 15 133 0 0 182 196 115 102 51 50 0 0 0 0 0 1 12 63 0 0 5 220 255 255 243 39 0 0 7 144 0 0 253 146 255 255 251 162 255 255 253 163 0 0 3 220 0 0 192 113 116 101 120 116 0 0 0 0 67 111 112 121 114 105 103 104 116 32 40 99 41 32 50 48 48 51 44 32 67 97 110 111 110 32 73 110 99 46 32 32 65 108 108 32 114 105 103 104 116 115 32 114 101 115 101 114 118 101 100 46 0 0 0 0 100 101 115 99 0 0 0 0 0 0 0 11 67 97 110 111 110 32 73 110 99 46 0 0 0 0 0 0 0 0 10 0 67 0 97 0 110 0 111 0 110 0 32 0 73 0 110 0 99 0 46 0 0 11 67 97 110 111 110 32 73 110 99 46 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 100 101 115 99 0 0 0 0 0 0 0 19 115 82 71 66 32 118 49 46 51 49 32 40 67 97 110 111 110 41 0 0 0 0 0 0 0 0 18 0 115 0 82 0 71 0 66 0 32 0 118 0 49 0 46 0 51 0 49 0 32 0 40 0 67 0 97 0 110 0 111 0 110 0 41 0 0 19 115 82 71 66 32 118 49 46 51 49 32 40 67 97 110 111 110 41 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 88 89 90 32 0 0 0 0 0 0 246 214 0 1 0 0 0 0 211 45 115 105 103 32 0 0 0 0 67 82 84 32 117 99 109 73 67 83 73 71 0 0 1 40 1 8 0 0 1 8 0 0 1 0 0 0 0 0 0 1 0 0 0 1 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 86 73 84 32 76 97 98 111 114 97 116 111 114 121 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 67 73 78 67 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 243 84 0 1 0 0 0 1 22 207 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 3 0 0 0 0 0 0 0 0 0 20 0 0 0 0 0 1 0 1 0 0 0 0 0 1 "
			{
				var entry = structure.GetEntry (0, (ushort) IFDEntryTag.ICCProfile);
				Assert.IsNotNull (entry, "Entry 0x8773 missing in IFD 0");
				Assert.IsNotNull (entry as UndefinedIFDEntry, "Entry is not an undefined IFD entry!");
				var bytes = new byte [] { 0, 0, 12, 68, 85, 67, 67, 77, 2, 64, 0, 0, 109, 110, 116, 114, 82, 71, 66, 32, 88, 89, 90, 32, 7, 211, 0, 4, 0, 4, 0, 0, 0, 0, 0, 0, 97, 99, 115, 112, 77, 83, 70, 84, 0, 0, 0, 0, 67, 65, 78, 79, 90, 48, 48, 57, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 246, 214, 0, 1, 0, 0, 0, 0, 211, 45, 67, 65, 78, 79, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 14, 114, 84, 82, 67, 0, 0, 1, 44, 0, 0, 8, 12, 103, 84, 82, 67, 0, 0, 1, 44, 0, 0, 8, 12, 98, 84, 82, 67, 0, 0, 1, 44, 0, 0, 8, 12, 114, 88, 89, 90, 0, 0, 9, 56, 0, 0, 0, 20, 103, 88, 89, 90, 0, 0, 9, 76, 0, 0, 0, 20, 98, 88, 89, 90, 0, 0, 9, 96, 0, 0, 0, 20, 99, 104, 97, 100, 0, 0, 9, 116, 0, 0, 0, 44, 99, 112, 114, 116, 0, 0, 9, 160, 0, 0, 0, 64, 100, 109, 110, 100, 0, 0, 9, 224, 0, 0, 0, 124, 100, 109, 100, 100, 0, 0, 10, 92, 0, 0, 0, 148, 119, 116, 112, 116, 0, 0, 10, 240, 0, 0, 0, 20, 116, 101, 99, 104, 0, 0, 11, 4, 0, 0, 0, 12, 100, 101, 115, 99, 0, 0, 10, 92, 0, 0, 0, 148, 117, 99, 109, 73, 0, 0, 11, 16, 0, 0, 1, 52, 99, 117, 114, 118, 0, 0, 0, 0, 0, 0, 4, 0, 0, 0, 0, 4, 0, 9, 0, 14, 0, 19, 0, 24, 0, 29, 0, 34, 0, 39, 0, 44, 0, 49, 0, 54, 0, 59, 0, 64, 0, 69, 0, 74, 0, 79, 0, 84, 0, 89, 0, 94, 0, 99, 0, 104, 0, 109, 0, 114, 0, 118, 0, 123, 0, 128, 0, 133, 0, 138, 0, 143, 0, 148, 0, 153, 0, 158, 0, 163, 0, 168, 0, 173, 0, 178, 0, 183, 0, 188, 0, 193, 0, 198, 0, 203, 0, 208, 0, 213, 0, 218, 0, 223, 0, 229, 0, 234, 0, 240, 0, 245, 0, 251, 1, 1, 1, 6, 1, 12, 1, 18, 1, 24, 1, 30, 1, 36, 1, 43, 1, 49, 1, 55, 1, 62, 1, 68, 1, 75, 1, 82, 1, 89, 1, 95, 1, 102, 1, 109, 1, 117, 1, 124, 1, 131, 1, 138, 1, 146, 1, 153, 1, 161, 1, 169, 1, 176, 1, 184, 1, 192, 1, 200, 1, 208, 1, 216, 1, 225, 1, 233, 1, 241, 1, 250, 2, 2, 2, 11, 2, 20, 2, 29, 2, 38, 2, 47, 2, 56, 2, 65, 2, 74, 2, 83, 2, 93, 2, 102, 2, 112, 2, 122, 2, 131, 2, 141, 2, 151, 2, 161, 2, 172, 2, 182, 2, 192, 2, 202, 2, 213, 2, 224, 2, 234, 2, 245, 3, 0, 3, 11, 3, 22, 3, 33, 3, 44, 3, 55, 3, 67, 3, 78, 3, 90, 3, 102, 3, 113, 3, 125, 3, 137, 3, 149, 3, 161, 3, 173, 3, 186, 3, 198, 3, 211, 3, 223, 3, 236, 3, 249, 4, 6, 4, 19, 4, 32, 4, 45, 4, 58, 4, 71, 4, 85, 4, 98, 4, 112, 4, 126, 4, 140, 4, 154, 4, 168, 4, 182, 4, 196, 4, 210, 4, 225, 4, 239, 4, 254, 5, 13, 5, 27, 5, 42, 5, 57, 5, 72, 5, 88, 5, 103, 5, 118, 5, 134, 5, 149, 5, 165, 5, 181, 5, 197, 5, 213, 5, 229, 5, 245, 6, 5, 6, 22, 6, 38, 6, 55, 6, 72, 6, 88, 6, 105, 6, 122, 6, 139, 6, 157, 6, 174, 6, 191, 6, 209, 6, 227, 6, 244, 7, 6, 7, 24, 7, 42, 7, 60, 7, 79, 7, 97, 7, 115, 7, 134, 7, 153, 7, 171, 7, 190, 7, 209, 7, 228, 7, 248, 8, 11, 8, 30, 8, 50, 8, 69, 8, 89, 8, 109, 8, 129, 8, 149, 8, 169, 8, 190, 8, 210, 8, 230, 8, 251, 9, 16, 9, 36, 9, 57, 9, 78, 9, 100, 9, 121, 9, 142, 9, 164, 9, 185, 9, 207, 9, 229, 9, 251, 10, 17, 10, 39, 10, 61, 10, 83, 10, 106, 10, 128, 10, 151, 10, 174, 10, 197, 10, 220, 10, 243, 11, 10, 11, 33, 11, 57, 11, 80, 11, 104, 11, 128, 11, 152, 11, 176, 11, 200, 11, 224, 11, 249, 12, 17, 12, 42, 12, 66, 12, 91, 12, 116, 12, 141, 12, 166, 12, 192, 12, 217, 12, 242, 13, 12, 13, 38, 13, 64, 13, 90, 13, 116, 13, 142, 13, 168, 13, 195, 13, 221, 13, 248, 14, 19, 14, 46, 14, 73, 14, 100, 14, 127, 14, 154, 14, 182, 14, 209, 14, 237, 15, 9, 15, 37, 15, 65, 15, 93, 15, 121, 15, 150, 15, 178, 15, 207, 15, 236, 16, 9, 16, 38, 16, 67, 16, 96, 16, 125, 16, 155, 16, 185, 16, 214, 16, 244, 17, 18, 17, 48, 17, 78, 17, 109, 17, 139, 17, 170, 17, 200, 17, 231, 18, 6, 18, 37, 18, 68, 18, 100, 18, 131, 18, 163, 18, 194, 18, 226, 19, 2, 19, 34, 19, 66, 19, 99, 19, 131, 19, 164, 19, 196, 19, 229, 20, 6, 20, 39, 20, 72, 20, 105, 20, 139, 20, 172, 20, 206, 20, 240, 21, 17, 21, 52, 21, 86, 21, 120, 21, 154, 21, 189, 21, 223, 22, 2, 22, 37, 22, 72, 22, 107, 22, 143, 22, 178, 22, 213, 22, 249, 23, 29, 23, 65, 23, 101, 23, 137, 23, 173, 23, 210, 23, 246, 24, 27, 24, 64, 24, 101, 24, 138, 24, 175, 24, 212, 24, 250, 25, 31, 25, 69, 25, 107, 25, 145, 25, 183, 25, 221, 26, 3, 26, 42, 26, 80, 26, 119, 26, 158, 26, 197, 26, 236, 27, 19, 27, 59, 27, 98, 27, 138, 27, 177, 27, 217, 28, 1, 28, 41, 28, 82, 28, 122, 28, 163, 28, 203, 28, 244, 29, 29, 29, 70, 29, 111, 29, 153, 29, 194, 29, 236, 30, 22, 30, 63, 30, 105, 30, 147, 30, 190, 30, 232, 31, 19, 31, 61, 31, 104, 31, 147, 31, 190, 31, 233, 32, 21, 32, 64, 32, 108, 32, 151, 32, 195, 32, 239, 33, 27, 33, 72, 33, 116, 33, 161, 33, 205, 33, 250, 34, 39, 34, 84, 34, 129, 34, 175, 34, 220, 35, 10, 35, 55, 35, 101, 35, 147, 35, 194, 35, 240, 36, 30, 36, 77, 36, 124, 36, 170, 36, 217, 37, 8, 37, 56, 37, 103, 37, 151, 37, 198, 37, 246, 38, 38, 38, 86, 38, 134, 38, 183, 38, 231, 39, 24, 39, 73, 39, 121, 39, 170, 39, 220, 40, 13, 40, 62, 40, 112, 40, 162, 40, 212, 41, 6, 41, 56, 41, 106, 41, 157, 41, 207, 42, 2, 42, 53, 42, 104, 42, 155, 42, 206, 43, 1, 43, 53, 43, 105, 43, 157, 43, 209, 44, 5, 44, 57, 44, 109, 44, 162, 44, 215, 45, 11, 45, 64, 45, 117, 45, 171, 45, 224, 46, 22, 46, 75, 46, 129, 46, 183, 46, 237, 47, 35, 47, 90, 47, 144, 47, 199, 47, 254, 48, 53, 48, 108, 48, 163, 48, 218, 49, 18, 49, 74, 49, 129, 49, 185, 49, 241, 50, 42, 50, 98, 50, 155, 50, 211, 51, 12, 51, 69, 51, 126, 51, 183, 51, 241, 52, 42, 52, 100, 52, 158, 52, 216, 53, 18, 53, 76, 53, 135, 53, 193, 53, 252, 54, 55, 54, 114, 54, 173, 54, 232, 55, 36, 55, 95, 55, 155, 55, 215, 56, 19, 56, 79, 56, 140, 56, 200, 57, 5, 57, 65, 57, 126, 57, 187, 57, 249, 58, 54, 58, 115, 58, 177, 58, 239, 59, 45, 59, 107, 59, 169, 59, 231, 60, 38, 60, 101, 60, 164, 60, 227, 61, 34, 61, 97, 61, 160, 61, 224, 62, 32, 62, 96, 62, 160, 62, 224, 63, 32, 63, 97, 63, 161, 63, 226, 64, 35, 64, 100, 64, 165, 64, 231, 65, 40, 65, 106, 65, 172, 65, 238, 66, 48, 66, 114, 66, 180, 66, 247, 67, 58, 67, 125, 67, 192, 68, 3, 68, 70, 68, 138, 68, 205, 69, 17, 69, 85, 69, 153, 69, 221, 70, 34, 70, 102, 70, 171, 70, 240, 71, 53, 71, 122, 71, 191, 72, 5, 72, 74, 72, 144, 72, 214, 73, 28, 73, 98, 73, 169, 73, 239, 74, 54, 74, 125, 74, 196, 75, 11, 75, 82, 75, 154, 75, 225, 76, 41, 76, 113, 76, 185, 77, 2, 77, 74, 77, 146, 77, 219, 78, 36, 78, 109, 78, 182, 79, 0, 79, 73, 79, 147, 79, 220, 80, 38, 80, 112, 80, 187, 81, 5, 81, 80, 81, 154, 81, 229, 82, 48, 82, 124, 82, 199, 83, 18, 83, 94, 83, 170, 83, 246, 84, 66, 84, 142, 84, 219, 85, 39, 85, 116, 85, 193, 86, 14, 86, 91, 86, 169, 86, 246, 87, 68, 87, 146, 87, 224, 88, 46, 88, 124, 88, 203, 89, 26, 89, 104, 89, 183, 90, 7, 90, 86, 90, 165, 90, 245, 91, 69, 91, 149, 91, 229, 92, 53, 92, 133, 92, 214, 93, 39, 93, 119, 93, 201, 94, 26, 94, 107, 94, 189, 95, 14, 95, 96, 95, 178, 96, 4, 96, 87, 96, 169, 96, 252, 97, 79, 97, 162, 97, 245, 98, 72, 98, 155, 98, 239, 99, 67, 99, 151, 99, 235, 100, 63, 100, 148, 100, 232, 101, 61, 101, 146, 101, 231, 102, 60, 102, 146, 102, 231, 103, 61, 103, 147, 103, 233, 104, 63, 104, 149, 104, 236, 105, 67, 105, 153, 105, 240, 106, 72, 106, 159, 106, 247, 107, 78, 107, 166, 107, 254, 108, 86, 108, 175, 109, 7, 109, 96, 109, 185, 110, 17, 110, 107, 110, 196, 111, 29, 111, 119, 111, 209, 112, 43, 112, 133, 112, 223, 113, 58, 113, 148, 113, 239, 114, 74, 114, 165, 115, 1, 115, 92, 115, 184, 116, 19, 116, 111, 116, 204, 117, 40, 117, 132, 117, 225, 118, 62, 118, 155, 118, 248, 119, 85, 119, 179, 120, 16, 120, 110, 120, 204, 121, 42, 121, 136, 121, 231, 122, 69, 122, 164, 123, 3, 123, 98, 123, 193, 124, 33, 124, 129, 124, 224, 125, 64, 125, 160, 126, 1, 126, 97, 126, 194, 127, 35, 127, 132, 127, 229, 128, 70, 128, 168, 129, 9, 129, 107, 129, 205, 130, 47, 130, 145, 130, 244, 131, 87, 131, 185, 132, 28, 132, 128, 132, 227, 133, 70, 133, 170, 134, 14, 134, 114, 134, 214, 135, 58, 135, 159, 136, 4, 136, 104, 136, 205, 137, 51, 137, 152, 137, 254, 138, 99, 138, 201, 139, 47, 139, 149, 139, 252, 140, 98, 140, 201, 141, 48, 141, 151, 141, 254, 142, 102, 142, 205, 143, 53, 143, 157, 144, 5, 144, 109, 144, 214, 145, 63, 145, 167, 146, 16, 146, 121, 146, 227, 147, 76, 147, 182, 148, 32, 148, 138, 148, 244, 149, 94, 149, 201, 150, 51, 150, 158, 151, 9, 151, 117, 151, 224, 152, 76, 152, 183, 153, 35, 153, 143, 153, 251, 154, 104, 154, 213, 155, 65, 155, 174, 156, 27, 156, 137, 156, 246, 157, 100, 157, 210, 158, 64, 158, 174, 159, 28, 159, 139, 159, 249, 160, 104, 160, 215, 161, 70, 161, 182, 162, 37, 162, 149, 163, 5, 163, 117, 163, 229, 164, 86, 164, 198, 165, 55, 165, 168, 166, 25, 166, 139, 166, 252, 167, 110, 167, 224, 168, 82, 168, 196, 169, 54, 169, 169, 170, 28, 170, 142, 171, 2, 171, 117, 171, 232, 172, 92, 172, 208, 173, 68, 173, 184, 174, 44, 174, 161, 175, 21, 175, 138, 175, 255, 176, 116, 176, 234, 177, 95, 177, 213, 178, 75, 178, 193, 179, 55, 179, 174, 180, 36, 180, 155, 181, 18, 181, 137, 182, 1, 182, 120, 182, 240, 183, 104, 183, 224, 184, 88, 184, 209, 185, 73, 185, 194, 186, 59, 186, 180, 187, 45, 187, 167, 188, 33, 188, 154, 189, 20, 189, 143, 190, 9, 190, 132, 190, 254, 191, 121, 191, 244, 192, 112, 192, 235, 193, 103, 193, 227, 194, 95, 194, 219, 195, 87, 195, 212, 196, 81, 196, 205, 197, 75, 197, 200, 198, 69, 198, 195, 199, 65, 199, 191, 200, 61, 200, 187, 201, 58, 201, 185, 202, 56, 202, 183, 203, 54, 203, 181, 204, 53, 204, 181, 205, 53, 205, 181, 206, 53, 206, 182, 207, 55, 207, 184, 208, 57, 208, 186, 209, 59, 209, 189, 210, 63, 210, 193, 211, 67, 211, 197, 212, 72, 212, 203, 213, 78, 213, 209, 214, 84, 214, 216, 215, 91, 215, 223, 216, 99, 216, 231, 217, 108, 217, 240, 218, 117, 218, 250, 219, 127, 220, 4, 220, 138, 221, 16, 221, 150, 222, 28, 222, 162, 223, 40, 223, 175, 224, 54, 224, 189, 225, 68, 225, 203, 226, 83, 226, 218, 227, 98, 227, 234, 228, 115, 228, 251, 229, 132, 230, 13, 230, 150, 231, 31, 231, 168, 232, 50, 232, 188, 233, 70, 233, 208, 234, 90, 234, 229, 235, 111, 235, 250, 236, 133, 237, 16, 237, 156, 238, 39, 238, 179, 239, 63, 239, 203, 240, 88, 240, 228, 241, 113, 241, 254, 242, 139, 243, 25, 243, 166, 244, 52, 244, 194, 245, 80, 245, 222, 246, 108, 246, 251, 247, 138, 248, 25, 248, 168, 249, 55, 249, 199, 250, 87, 250, 231, 251, 119, 252, 7, 252, 152, 253, 40, 253, 185, 254, 74, 254, 219, 255, 109, 255, 255, 88, 89, 90, 32, 0, 0, 0, 0, 0, 0, 111, 160, 0, 0, 56, 242, 0, 0, 3, 143, 88, 89, 90, 32, 0, 0, 0, 0, 0, 0, 98, 150, 0, 0, 183, 138, 0, 0, 24, 218, 88, 89, 90, 32, 0, 0, 0, 0, 0, 0, 36, 160, 0, 0, 15, 133, 0, 0, 182, 196, 115, 102, 51, 50, 0, 0, 0, 0, 0, 1, 12, 63, 0, 0, 5, 220, 255, 255, 243, 39, 0, 0, 7, 144, 0, 0, 253, 146, 255, 255, 251, 162, 255, 255, 253, 163, 0, 0, 3, 220, 0, 0, 192, 113, 116, 101, 120, 116, 0, 0, 0, 0, 67, 111, 112, 121, 114, 105, 103, 104, 116, 32, 40, 99, 41, 32, 50, 48, 48, 51, 44, 32, 67, 97, 110, 111, 110, 32, 73, 110, 99, 46, 32, 32, 65, 108, 108, 32, 114, 105, 103, 104, 116, 115, 32, 114, 101, 115, 101, 114, 118, 101, 100, 46, 0, 0, 0, 0, 100, 101, 115, 99, 0, 0, 0, 0, 0, 0, 0, 11, 67, 97, 110, 111, 110, 32, 73, 110, 99, 46, 0, 0, 0, 0, 0, 0, 0, 0, 10, 0, 67, 0, 97, 0, 110, 0, 111, 0, 110, 0, 32, 0, 73, 0, 110, 0, 99, 0, 46, 0, 0, 11, 67, 97, 110, 111, 110, 32, 73, 110, 99, 46, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 100, 101, 115, 99, 0, 0, 0, 0, 0, 0, 0, 19, 115, 82, 71, 66, 32, 118, 49, 46, 51, 49, 32, 40, 67, 97, 110, 111, 110, 41, 0, 0, 0, 0, 0, 0, 0, 0, 18, 0, 115, 0, 82, 0, 71, 0, 66, 0, 32, 0, 118, 0, 49, 0, 46, 0, 51, 0, 49, 0, 32, 0, 40, 0, 67, 0, 97, 0, 110, 0, 111, 0, 110, 0, 41, 0, 0, 19, 115, 82, 71, 66, 32, 118, 49, 46, 51, 49, 32, 40, 67, 97, 110, 111, 110, 41, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 88, 89, 90, 32, 0, 0, 0, 0, 0, 0, 246, 214, 0, 1, 0, 0, 0, 0, 211, 45, 115, 105, 103, 32, 0, 0, 0, 0, 67, 82, 84, 32, 117, 99, 109, 73, 67, 83, 73, 71, 0, 0, 1, 40, 1, 8, 0, 0, 1, 8, 0, 0, 1, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 86, 73, 84, 32, 76, 97, 98, 111, 114, 97, 116, 111, 114, 121, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 67, 73, 78, 67, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 243, 84, 0, 1, 0, 0, 0, 1, 22, 207, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 20, 0, 0, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 0, 1 };
				var parsed_bytes = (entry as UndefinedIFDEntry).Data.Data;
				Assert.AreEqual (bytes, parsed_bytes);
			}

			//  ---------- End of IFD tests ----------

		}
	}
}
