################################################################################
# Automatically-generated file. Do not edit!
################################################################################

# Add inputs and outputs from these tool invocations to the build variables 
CPP_SRCS += \
../src/stretching/kalman_manager.cpp \
../src/stretching/sequence.cpp \
../src/stretching/sm_sensor.cpp \
../src/stretching/stretch_manager.cpp 

C_SRCS += \
../src/stretching/action_icon.c \
../src/stretching/hmm_model.c \
../src/stretching/sm_view.c 

OBJS += \
./src/stretching/action_icon.o \
./src/stretching/hmm_model.o \
./src/stretching/kalman_manager.o \
./src/stretching/sequence.o \
./src/stretching/sm_sensor.o \
./src/stretching/sm_view.o \
./src/stretching/stretch_manager.o 

C_DEPS += \
./src/stretching/action_icon.d \
./src/stretching/hmm_model.d \
./src/stretching/sm_view.d 

CPP_DEPS += \
./src/stretching/kalman_manager.d \
./src/stretching/sequence.d \
./src/stretching/sm_sensor.d \
./src/stretching/stretch_manager.d 


# Each subdirectory must supply rules for building sources it contributes
src/stretching/%.o: ../src/stretching/%.c
	@echo 'Building file: $<'
	@echo 'Invoking: C Compiler'
	$(CC) -I"pch" -D_DEBUG -I"$(PROJ_PATH)\inc" -I@system_includes -I"$(PROJ_PATH)\inc\stretching" -O0 -g3 -Wall -c -fmessage-length=0 $(TC_COMPILER_MISC) $(RS_COMPILER_MISC) -fPIE --sysroot="$(SBI_SYSROOT)" -I@system_includes -Werror-implicit-function-declaration -MMD -MP -MF"$(@:%.o=%.d)" -MT"$(@:%.o=%.d)" -o "$@" "$<"
	@echo 'Finished building: $<'
	@echo ' '

src/stretching/%.o: ../src/stretching/%.cpp
	@echo 'Building file: $<'
	@echo 'Invoking: C++ Compiler'
	$(CXX) -I"pch" -D_DEBUG -I"$(PROJ_PATH)\inc" -I@system_includes -I"$(PROJ_PATH)\inc\stretching" -O0 -g3 -Wall -c -fmessage-length=0 $(TC_COMPILER_MISC) -fPIE --sysroot="$(SBI_SYSROOT)" -I@system_includes -MMD -MP -MF"$(@:%.o=%.d)" -MT"$(@:%.o=%.d)" -o "$@" "$<"
	@echo 'Finished building: $<'
	@echo ' '


